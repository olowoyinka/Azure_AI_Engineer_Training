@echo off

rem Set values for your Language Understanding app
set app_id=35a2928a-bef4-44f5-a0cc-050201a6d5b1
set endpoint=https://yinkalanguage.cognitiveservices.azure.com/
set key=be3e4f8805804e298246a2c68dcb6649

rem Get parameter and encode spaces for URL
set input=%1
set query=%input: =+%

rem Use cURL to call the REST API
curl -X GET "%endpoint%/luis/prediction/v3.0/apps/%app_id%/slots/production/predict?subscription-key=%key%&log=true&query=%query%"