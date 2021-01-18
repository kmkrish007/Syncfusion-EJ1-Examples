// Ionic Starter App

// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
var example = angular.module('starter', ['ejangular','ionic', 'ngCordova'])

.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
    // for form inputs).
    // The reason we default this to hidden is that native apps don't usually show an accessory bar, at
    // least on iOS. It's a dead giveaway that an app is using a Web View. However, it's sometimes
    // useful especially with forms, though we would prefer giving the user a little more room
    // to interact with the app.
    if (window.cordova && window.Keyboard) {
      window.Keyboard.hideKeyboardAccessoryBar(true);
    }

    if (window.StatusBar) {
      // Set the statusbar to use the default style, tweak this to
      // remove the status bar on iOS or change it to use white instead of dark colors.
      StatusBar.styleDefault();
    }
  });
})

example.controller("ListController", function($scope, $rootScope) {
  $scope.datalist = [
    { "Name": "Brooke", "Class": "brooke", "Designation": "HR Assistant", "About": "Brooke provides administrative support to the HR office." },
  { "Name": "Claire", "Class": "claire", "Designation": "HR Manager", "About": "Claire is responsible for strategic HR planning and budget." },
  { "Name": "Erik", "Class": "erik", "Designation": "Training Specialist", "About": "Erik notifies attendees and manages follow up." },
  { "Name": "Grace", "Class": "grace", "Designation": "Development Manager", "About": "Grace maintains training plans to achive workforce skill." },
  { "Name": "Jacob", "Class": "jacob", "Designation": "Recruitment Manager", "About": "Jacob manages recruitment and prepares key staffing metrics." }];
});
