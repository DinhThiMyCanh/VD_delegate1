pipeline {
    agent any
    stages{
        stage('Git clone'){
            steps{
                git branch: 'master', url: 'https://github.com/DinhThiMyCanh/VD_delegate1.git'
            }  
        }

        stage('Check folder'){
            steps{
                sh "ls"
            }  
        }

        stage('Build'){
            steps{
                echo "Build completed"
            }  
        }

    }
}
