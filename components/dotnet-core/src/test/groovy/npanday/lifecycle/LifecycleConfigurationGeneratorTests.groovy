package npanday.lifecycle

import java.io.File;

import npanday.ArtifactType

import org.junit.After;
import org.junit.Before;
import org.junit.Test

/**
 * @author Lars Corneliussen
 */
class LifecycleConfigurationGeneratorTests {
	
	File tempDir
	
	@Before
	final void setup(){
		tempDir = new File(System.properties["java.io.tmpdir"], this.class.name)
		tempDir.mkdirs()
	}
	
	@After
	final void teardown(){
		tempDir.deleteDir()
	}
	
	@Test
	void constructs() {
		def generator = new LifecycleConfigurationGenerator("<component-set/>")
	}
	
	@Test
	void currentIsAvailable() {
		def g = new LifecycleConfigurationGenerator("<component-set/>")
		assert "<component-set/>" == g.currentXml
	}
	
	@Test
	void addNoComponent_preservesComponents() {
		def g = new LifecycleConfigurationGenerator("<component-set><components><component id='a'/></components></component-set>")
		
		Closure comps = { }
		g.appendComponents(comps)

		def root = new XmlSlurper().parseText(g.currentXml)
		assert 1 == root.components.component.size()
		assert "a" == root.components.component[0].@id.text()
	}
	
	@Test
	void addComponent() {
		def g = new LifecycleConfigurationGenerator("<component-set><components><component id='a'/></components></component-set>")
		
		Closure comps = { component( id: 'b' ) }
		g.appendComponents(comps)
		
		def root = new XmlSlurper().parseText(g.currentXml)
		assert 2 == root.components.component.size()
		assert root.components.component.collect{it.@id.text()} == ["a", "b"]
	}
	
	@Test
	void configureDotnetLibraryMapping() {
		def g = new LifecycleConfigurationGenerator()
		g.configureMappings ([new LifecycleMapping(type: ArtifactType.DOTNET_LIBRARY, steps: null)])

		def root = new XmlSlurper().parseText(g.currentXml)
		assert 1 == root.components.component.size()
		assert ArtifactType.DOTNET_LIBRARY.packagingType == root.components.component[0].'role-hint'.text()
	}
	
	@Test
	void configureDotnetLibraryType() {
		def g = new LifecycleConfigurationGenerator()
		g.configureTypes ([ArtifactType.DOTNET_LIBRARY])

		def root = new XmlSlurper().parseText(g.currentXml)
		assert 1 == root.components.component.size()
		assert ArtifactType.DOTNET_LIBRARY.packagingType == root.components.component[0].'role-hint'.text()
	}
	
	@Test
	void configureTwice() {
		def g = new LifecycleConfigurationGenerator()
		g.appendComponents{component(1)}
		g.appendComponents{component(2)}
		def root = new XmlSlurper().parseText(g.currentXml)
		assert 2 == root.components.component.size()
	}
	
	@Test 
	void extendFile() {
		def file = {return new File(tempDir, "components.xml")}
		file().text = "<component-set/>"
		
		LifecycleConfigurationGenerator.persistAllTypesAndLifecycles(TestLifecycleMap, file())
		
		def root = new XmlSlurper().parseText(file().text)
		def size = root.components.component.size()
		assert size > 1
		assert "dotnet-library" == root.components.component[size-1].'role-hint'.text()
	}
}