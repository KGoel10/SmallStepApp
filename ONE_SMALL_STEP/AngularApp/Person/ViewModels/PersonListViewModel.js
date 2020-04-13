


app.controller("personListViewModel", function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {


    //personModule.controller("PersonListViewModel", function ($scope, $http, $q, $routeParams, $window, $location, viewModelHelper) {


    $scope.viewModelHelper = viewModelHelper;
    $scope.personService = personService;

    var initialize = function () {
        $scope.refreshPersons();
        $scope.DISPLAY_TEST = "DISPLAY TEST";
        //alert("initialize")
    }

    $scope.refreshPersons = function () {
        viewModelHelper.apiGet('api/person', null,
            function (result) {
                //$scope.customers = result.data;
                //alert("person list");
                //console.log(result.data);
                $scope.persons = result.data;
                //alert("TESTING");
            });
    }

    initialize();



    $scope.deletePersonFromList = function (idx) {
        var personToDelete = $scope.persons[idx];
        //alert("index:" + idx);
        //alert(personToDelete.PersonID);
        //alert(personToDelete);
        $scope.persons.splice(idx, 1);
        //$scope.deletePerson2({ personId: personToDelete.personId }); CHECK ON THIS -- DON'T FOLLOW IT!!
        $scope.deletePerson2(personToDelete.PersonID);
    }



    $scope.deletePerson2 = function (personId) {
        //alert(personId);
        viewModelHelper.apiDelete("api/person/delete/" + personId, null,
            function (result) {

                // alert("here is result " + personId);
                //personService.personId = personId;
                //$scope.person = result.data;
                //$scope.getPersonType();
                //alert(personId);

                // alert(result.data);
                //console.log(result.data);

                //alert(personId);
            });

        //viewModelHelper.navigateTo('person/list');


    }


    //alert("after initialize");

    /*
    var url = "http://localhost:54064/api/person";
    var MainController = function ($scope, $http) {

        var onSuccess = function (response) {
            $scope.persons = response.data
        };
        var onFailure = function (error) {
            $scope.error = reason
        };

        var getAllPersons = function () {
            $http.get(url)
                .then(onSuccess, onFailure)

        }

        getAllPersons();
       

    }
     */
    //$scope.showCustomer = function (customer) {
    //    $scope.flags.shownFromList = true; // note this object is declared in the RootViewModel
    //    viewModelHelper.navigateTo('customer/show/' + customer.CustomerId);
    //}

    //$scope.deletePersonTEST2 = function () {
    //    alert("delete test 2");
    //    if (personService.personId != 0) {
    //        // $scope.flags.shownFromList = false;
    //        //alert("hello");
    //        viewModelHelper.navigateTo(
    //            'person/Delete/' + personService.personId);
    //        //alert(personService.personId);
    //    };

    //}



});
