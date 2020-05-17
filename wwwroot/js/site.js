// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// window.onload = function (array) {

var myFunction = function(array){
var dataPoints = [];
array.forEach(element => {
    dataPoints.push({
        y : element
    });
});
// iteratively fill the datapoints array

var chart = new CanvasJS.Chart("chartContainer", {
animationEnabled: true,
theme: "light2",
title:{
    text: "Your Daily Usage of 750 Words"
},
axisY:{
    includeZero: false,
    interval: 1,
    title: "Number of Words per Entry"
},
axisX:{
    interval: 1,
    title: "Number of Entries"
},
data: [{        
    type: "column",
    indexLabelFontSize: 16,  
    dataPoints: dataPoints
    }
]
});
chart.render();

}
