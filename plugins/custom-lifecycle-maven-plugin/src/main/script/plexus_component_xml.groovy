import npanday.plugin.customlifecycle.CustomLifecycleMap;
import npanday.lifecycle.LifecycleMapping;
import npanday.lifecycle.LifecycleStep;

/* Groovy script that generates the META-INF/plexus/components.xml 
 * with all known artifact types for npanday and the
 * custom lifecycles that are defined in 
 * npanday.plugin.customlifecycle.CustomLifecycleMap
 * 
 * @author Lars Corneliussen
 * 
 */

List types = npanday.ArtifactType.values()
    .findAll{it != npanday.ArtifactType.NULL}

List<LifecycleMapping> lifecycleMappings = new CustomLifecycleMap().map;

def plexus = new File(project.build.outputDirectory, 'META-INF/plexus')
plexus.mkdirs()

new File(plexus, 'components.xml').withWriter('UTF-8') { writer ->
	def xml = new groovy.xml.MarkupBuilder(writer)
	xml.'component-set' {
		components{
			types.each{ typeDef ->
				component{
					role 'org.apache.maven.artifact.handler.ArtifactHandler'
					'role-hint'(typeDef.packagingType)
					implementation 'org.apache.maven.artifact.handler.DefaultArtifactHandler'
					configuration{
						extension typeDef.extension
						type typeDef.packagingType
					}
				}
			}
			
			lifecycleMappings.each{ LifecycleMapping mapping ->
				component{
					role 'org.apache.maven.lifecycle.mapping.LifecycleMapping'
					'role-hint' mapping.type.packagingType
					implementation 'org.apache.maven.lifecycle.mapping.DefaultLifecycleMapping'
					configuration {
						phases {
							mapping.steps.each{LifecycleStep st ->
								"${st.phase}"("\n" 
    								+ " " * 12
    								+ st.goals.join(",\n" + " " * 12)
    								+ "\n" + " "*10)
							}
						}
					}
				}
			}
		}
	}
}