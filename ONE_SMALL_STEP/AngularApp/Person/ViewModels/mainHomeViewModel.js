app.controller("mainHomeViewModel", function (
    $scope, $http, $q, $routeParams, $window,
    $location, viewModelHelper) {

    var self = this;


    $scope.topic =
        "Integrating ASP.NET MVC and AngularJS";
    $scope.author = "Miguel A. Castro";

    console.log("THIS IS THE MAIN HOME VIEW MODEL BEING CALLED")
    $scope.viewModelHelper = viewModelHelper;
    //$scope.customerService = customerService;
    $scope.pageHeading = "This is the Main Home View Model";

    var initialize = function () {
        $scope.refreshCustomers();
        $scope.refreshPersons();
    }

    $scope.refreshCustomers = function () {
        console.log("inside refresh customers in mainHomeViewModel");
        viewModelHelper.apiGet('api/customers', null,
            function (result) {
                $scope.customers = result.data;
                //console.table($scope.customers);
            });
    }

    $scope.refreshPersons = function () {
        viewModelHelper.apiGet('api/person', null,
            function (result) {
                //$scope.customers = result.data;
                //alert("person list");
                //console.log(result.data);
                $scope.personList2 = result.data; //need to change persons to personList elsewhere
                //alert("TESTING");
                //console.table($scope.personList);
            });
    }


    //$scope.showCustomer = function (customer) {
    //    $scope.flags.shownFromList = true; // note this object is declared in the RootViewModel
    //    viewModelHelper.navigateTo('customer/show/' + customer.CustomerId);
    //}

    //initialize();




});















//mainModule.controller("mainHomeViewModel", function ($scope, customerService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

//    $scope.viewModelHelper = viewModelHelper;
//    $scope.customerService = customerService;
//    $scope.TEST_FROM_MAIN_MODULE = "test from main module";

//    var initialize = function () {
//        $scope.refreshCustomers();
//    }

//    $scope.refreshCustomers = function () {
//        viewModelHelper.apiGet('api/customers', null,
//            function (result) {
//                $scope.customers = result.data;
//            });
//    }

//    $scope.showCustomer = function (customer) {
//        $scope.flags.shownFromList = true; // note this object is declared in the RootViewModel
//        viewModelHelper.navigateTo('customer/show/' + customer.CustomerId);
//    }

//    initialize();
//});
