// define npanday core-types
List types = [
  [name: 'dotnet-library', ext: 'dll'],
  [name: 'dotnet-module', ext: 'netmodule'],
  [name: 'dotnet-exe.config', ext: 'exe.config'],
  [name: 'dotnet-asp', ext: 'dll'],
  [name: 'dotnet-winexe', ext: 'exe'],
  [name: 'dotnet-gac', ext: 'dll'],
  [name: 'dotnet-gac_generic', ext: 'dll'],
  [name: 'dotnet-gac_msil', ext: 'dll'],
  [name: 'dotnet-gac_32', ext: 'dll'],
  [name: 'dotnet-nar', ext: 'nar'],
  [name: 'dotnet-netplugin', ext: 'dll'],
  [name: 'dotnet-visual-studio-addin', ext: 'dll'],
]

// generate META-INF/plexus/components.xml

def plexus = new File(project.build.outputDirectory, 'META-INF/plexus')
plexus.mkdirs()

new File(plexus, 'components.xml').withWriter('UTF-8') { writer ->
	def xml = new groovy.xml.MarkupBuilder(writer)
	xml.'component-set' {
	    components{
			types.each{
				def typeDef = it
			    component{
			        role 'org.apache.maven.artifact.handler.ArtifactHandler'
					'role-hint'(typeDef.name)
					implementation 'org.apache.maven.artifact.handler.DefaultArtifactHandler'
					configuration{
			            extension typeDef.ext
						type typeDef.name
					}
				}
			}
		}
	}
}