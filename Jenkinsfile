pipeline {
    agent any
    stages{
        stage('Clone'){
            steps{
                git 'https://github.com/DinhThiMyCanh/VD_delegate1.git'
            }  
        }
        stage('Build'){
            steps{
                build 'VD_delegate1.sln'
            }
        }

    }
}
