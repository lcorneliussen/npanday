
List types = npanday.ArtifactType.values().collect{
    [name: it.packagingType, ext: it.extension]
}

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
				
				component{
			      role 'org.apache.maven.lifecycle.mapping.LifecycleMapping'
			      'role-hint' typeDef.name
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