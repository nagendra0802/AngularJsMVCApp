var eventModule = angular.module("eventModule", ['ngRoute']).config(function ($routeProvider) {
    //Path - it should be same as href link
    $routeProvider.when('/Talks', { templateUrl: '/Templates/Talk.html', controller: 'eventController' });
    $routeProvider.when('/Speakers', { templateUrl: '/Templates/Speaker.html', controller: 'speakerController' });
    $routeProvider.when('/Events/AddTalk', { templateUrl: '/Templates/AddTalk.html', controller: 'talkController' });
});