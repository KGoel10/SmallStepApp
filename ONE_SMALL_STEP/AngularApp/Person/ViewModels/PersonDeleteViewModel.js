app.controller("personDeleteViewModel",
    function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;
        $scope.personIdTEST = 0;

        var initialize = function () {
            //alert($routeParams.personId);

            $scope.refreshPerson($routeParams.personId);
            //alert($routeParams.personId);
            //$scope.personTypeList();
        }

        $scope.refreshPerson = function (personId) {
            //alert(personId);
            viewModelHelper.apiGet("api/person/" + personId, null,
                function (result) {
                    // alert("here is result " + personId);
                    personService.personId = personId;

                    $scope.personId = personId;
                    $scope.person = result.data;
                    $scope.getPersonType();
                    //alert(personId);

                    // alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }


        //$scope.deletePerson = function (){

        //            alert("TEST");
        //            // alert("here is result " + personId);
        //            //personService.personId = personId;
        //            //$scope.person = result.data;
        //            //$scope.getPersonType();
        //            //alert(personId);

        //            // alert(result.data);
        //            //console.log(result.data);

        //            //alert(personId);
        //        };



        $scope.deletePerson = function (personId) {
            alert(personId);
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

            viewModelHelper.navigateTo('person/list');


        }





        $scope.getPersonType = function () {
            viewModelHelper.apiGet("api/person/personType", null,
                function (result) {
                    //   alert("here is result " + personId);
                    //  personService.personId = personId;
                    //  alert("hello" + result.data);
                    $scope.personType = result.data;
                    //$scope.personTypeList();
                    ///     alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }


        //$scope.createPerson = function () {
        //    viewModelHelper.apiPost("api/create/person", null,
        //        function (result) {
        //            //   alert("here is result " + personId);
        //            //  personService.personId = personId;
        //            //  alert("hello" + result.data);
        //            alert("api/create/person");
        //            $scope.person = result.data;
        //            //$scope.personTypeList();
        //            ///     alert(result.data);
        //            //console.log(result.data);

        //            //alert(personId);
        //        });
        //}



        //$scope.personTypeList = function () {

        //    alert("before invokeing");
        //    viewModelHelper.apiGet("api/person/personType"), null,
        //        function (result) {
        //            alert("calling before result" + result.data);
        //            $scope.personType = result.data;
        //            alert("calling after result" + result.data);


        //        };
        //};

        initialize();
        //personTypeList();





        //alert("initialize");
    });
