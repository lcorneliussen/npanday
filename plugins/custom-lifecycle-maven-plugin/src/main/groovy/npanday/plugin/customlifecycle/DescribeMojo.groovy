/* 
 * Copyright 2010 NPanday
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package npanday.plugin.customlifecycle;

import org.codehaus.gmaven.mojo.GroovyMojo;
import npanday.ArtifactType;
import npanday.lifecycle.LifecycleMapping;
import npanday.lifecycle.LifecycleStep;
/**
 * @author Lars Corneliussen
 * @goal describe
 * @description Lists the types and lifecycles this plugin configures when used as an extension.
 */
class DescribeMojo
    extends GroovyMojo
{
	void execute() {
		
		List<ArtifactType> types = ArtifactType.values()
				.findAll{it != ArtifactType.NULL}
		
		List<LifecycleMapping> lifecycleMappings = new CustomLifecycleMap().map;
		
		types.each{type ->
			getLog().info("");
			getLog().info("artifact type: ${type.packagingType} (*.${type.extension})");
			
			def mapping = lifecycleMappings.find{it.type == type}
			if (mapping)
			{
				mapping.steps.eachWithIndex{step, stepPos ->
					getLog().info("  on ${step.phase} executes:")
                        step.goals.eachWithIndex{goal, goalPos ->
                        	getLog().info("    - ${goal}")
                        }
				}
			}
		}
	}
}
