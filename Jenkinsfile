pipeline {
	agent any

	stages {
		stage('checkout') {
			steps {
				checkout scm
			}
		}
		stage('build') {
			steps {
				script {
					bat "dotnet restore ${workspace}\\PipelineForBuildTest\\PipelineForBuildTest.csproj"
					bat "dotnet build ${workspace}\\PipelineForBuildTest\\PipelineForBuildTest.csproj --configuration Release"
				}
			}
		}
		stage('test') {
			steps {
				script {
					bat "dotnet test ${workspace}\\PipelineForBuildTest\\PipelineForBuildTest.csproj --no-restore --configuration Release"
				}
			}
		}
	}
}