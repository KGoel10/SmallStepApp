rootApp.service('navbarService', function ($rootScope,$scope, personService, $http, viewModelHelper) {

    $scope.TEST_DATA = "TEST DATA";
        this.tempData = "";
        this.SetData = function (d) {
            this.tempData = d;
            $rootScope.$emit("dummyevent")
        }


        this.GetData = function () {
            return this.tempData;
        }


    //$rootScope.personList = function () {
    $scope.personList = function () {
        alert(TEST_DATA);
            $scope.showPersonList = false;
            //alert($scope.showPersonList);
            viewModelHelper.navigateTo('person/list');

            //alert("nagigate to person/list");
        }

    });
//var mainModule = angular.module angular.module('main', ['common']);