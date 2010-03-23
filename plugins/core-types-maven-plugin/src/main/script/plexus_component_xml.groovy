// define npanday core-types

// TODO: Move to it's own file.
List types = [
  [name: 'dotnet-none', ext: 'none'],

  [name: 'dotnet-library', ext: 'dll'],
  [name: 'dotnet-library-config', ext: 'dll.config'],

  [name: 'dotnet-executable', ext: 'exe'],
  [name: 'dotnet-executable-config', ext: 'exe.config'],

  [name: 'dotnet-module', ext: 'netmodule'],
  
  [name: 'dotnet-asp', ext: 'dll'],
  [name: 'dotnet-gac', ext: 'dll'],
  [name: 'dotnet-gac_generic', ext: 'dll'],
  [name: 'dotnet-gac_msil', ext: 'dll'],
  [name: 'dotnet-gac_32', ext: 'dll'],
  [name: 'dotnet-nar', ext: 'nar'],
  [name: 'dotnet-netplugin', ext: 'dll'],
  [name: 'dotnet-visual-studio-addin', ext: 'dll'],

  [name: 'dotnet-symbols', ext: 'pdb'],
  [name: 'ole-type-library', ext: 'tlb'],

  //deprecated 
  [name: 'library', ext: 'dll'],
  [name: 'winexe', ext: 'exe'],
  [name: 'exe.config', ext: 'exe.config'],
  [name: 'module', ext: 'netmodule'],
  [name: 'asp', ext: 'dll'],
  [name: 'gac', ext: 'dll'],
  [name: 'gac_generic', ext: 'dll'],
  [name: 'gac_msil', ext: 'dll'],
  [name: 'gac_32', ext: 'dll'],
  [name: 'nar', ext: 'nar'],
  [name: 'netplugin', ext: 'dll'],
  [name: 'visual-studio-addin', ext: 'dll'],
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
				
				// empty-mapping for lifecycle without concrete artifacts
				component{
			      role 'org.apache.maven.lifecycle.mapping.LifecycleMapping'
			      'role-hint' 'dotnet-none'
			      implementation 'org.apache.maven.lifecycle.mapping.DefaultLifecycleMapping'
			      configuration {
			        phases {
			          
					}
			      }
				}	
			}
		}
	}
}