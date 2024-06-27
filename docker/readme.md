# Docker

## This docker folder has the following files

1. .yaml file for run the sample docker container compose
2. dockerfile for build the jenkins image
3. dockerfile for build the ngrok image

## Please follow the below steps to run the docker compose file

1. copy `sample.env` with `.env` and update the `NGROK_AUTHTOKEN` with your ngrok auth token
2. copy `docker-compose-sample.yaml` with `docker-compose.yaml` and update the `your-jenkins-file-dir` with your jenkins file directory
3. run compose file using `docker-compose -f docker-compose.yaml up -d`, it will run the jenkins and ngrok container on the background
4. stop the container using `docker-compose -f docker-compose.yaml down`


### Jenkins

1. Jenkins will run on port 8080 (<http://localhost:8080>)
2. Follow the jenkins initial setup and install the required plugins (recommended using standard plugins)
3. Create a new pipeline job and configure the pipeline with the below details
   - Repository URL: <Your-GitHub-Repository>
   - Eidt the branch name which you want to trigger the build
   - Choose the `Build Triggers/ GitHub hook trigger for GITScm polling`
