//var personModule = angular.module('person', ['common']);


app.config(function ($routeProvider,
    $locationProvider) {

    //$routeProvider.when('/person/show/:personId', {
    //    templateUrl: '/AngularApp/Person/Views/PersonView.html',
    //    controller: 'personViewModel'
    //});


    //$routeProvider.when('/person/delete/:personId', {
    //    templateUrl: '/AngularApp/Person/Views/PersonDeleteView.html',

    //    controller: 'personDeleteViewModel'

    //});


    //$routeProvider.when('/person/create', {
    //    templateUrl: '/AngularApp/Person/Views/PersonCreateView.html',
    //    controller: 'personCreateViewModel'
    //});


    //$routeProvider.when('/person/update', {
    //    templateUrl: '/AngularApp/Person/Views/PersonView.html',
    //    controller: 'personViewModel'
    //});




    //$routeProvider.when('/person/:personId', {
    //    templateUrl: '/AngularApp/Person/Views/PersonView.html',
    //    controller: 'personViewModel'
    //});


    //$routeProvider.when('/messageType/show/:messageTypeId', {
    //    templateUrl: '/AngularApp/Person/Views/MessageTypeView.html',
    //    controller: 'messageTypeViewModel'
    //});

    //$routeProvider.otherwise({
    //    redirectTo: '/person'
    //});
    //$routeProvider.when('/messagetype/list/', {
    //    templateUrl: '/AngularApp/Message/Views/MessageTypeListView.html',
    //    controller: 'messageTypeListViewModel'
    //});
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});



app.factory('personService',
    function ($http, $location, viewModelHelper) {
        return MyApp.personService($http,
            $location, viewModelHelper);
    });



(function (myApp) {
    var personService = function ($http, $location,
        viewModelHelper) {

        var self = this;

        self.personId = 0;

        return this;
    };
    myApp.personService = personService;
}(window.MyApp));







