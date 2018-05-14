#Tradingview Implementation for Binary.com Build Status

This repository contains HTML, Javascript, CSS, and images content of the Tradingview implementation for binary.com charts.

The project is coded in a way that same codebase could be used for both Mobile and Web.

It uses IntelXDK to generate Hybrid package for distribution in Apple and Google play store. For now, we are supporting iOS and Android devices only.

#Code/Folder details

bower_components - We use bower to manager dependencies. This folder holds all the dependent libraries

chart_library/datafeed - Our custom code to implement tradingview charting library

common.js - All commong JS functions

demo - Any demo/example code of different features of this project

images - Static resource files

index.html - Main starting page of this project. It will redirect to the appropriate current production/beta version

main.css - CSS used in main.html

main.html - Our main flie for this project

main.js - Our main JS file used in main.html

mobile_assets - All mobile related image/icon files
