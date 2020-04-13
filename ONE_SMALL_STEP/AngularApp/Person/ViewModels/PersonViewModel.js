app.controller("personViewModel",
    function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;
        $scope.personIdTEST = 0;

        $scope.pageHeading = "Contact Details";

        var initialize = function () {
            //alert($routeParams.personId);

            $scope.refreshPerson($routeParams.personId);
            //$scope.personTypeList();
        }

        $scope.refreshPerson = function (personId) {
            viewModelHelper.apiGet("api/person/" + personId, null,
                function (result) {
                    // alert("here is result " + personId);
                    personService.personId = personId;

                    $scope.personId = personId;
                    $scope.person = result.data;
                    $scope.getPersonType();
                    $scope.disableField();
                    //alert(personId);

                    // alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }

        $scope.showPerson = function (personId) {
            viewModelHelper.navigateTo("person/show/" + personId);
        }


        $scope.createPerson = function () {
            viewModelHelper.navigateTo("person/create");

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


        $scope.deletePerson2 = function (personId) {
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

        $scope.disableField = function () {
            document.getElementById("personFieldset").disabled = true;
        }

        $scope.enableField = function () {
            document.getElementById("personFieldset").disabled = false;
        }


        $scope.editPerson = function () {
            $scope.enableField();

        }


        $scope.savePerson2 = function (person) {
            //alert("create person test");

            //var personData = {
            //    //  PersonID: $scope.PersonID
            //    //,
            //    //  PersonID: $scope.personId
            //    //, FirstName: $scope.FirstName
            //    //, LastName: $scope.LastName
            //    //, EmailAddress: $scope.EmailAddress
            //    //, Screenshot: $scope.Screenshot
            //    //, PersonTypeID: $scope.PersonTypeID

            //    //                 PersonID: $scope.personId
            //    //, FirstName: $scope.FirstName
            //    //, LastName: $scope.LastName
            //    //, EmailAddress: $scope.EmailAddress
            //    //, Screenshot: $scope.Screenshot
            //    //, PersonTypeID: $scope.PersonTypeID


            //};
            //alert(person.LastName);
            //alert("TEST");
            //$scope.postPerson();
            //viewModelHelper.apiPut("api/person/update" + personId, personData,
            //test_func();

            viewModelHelper.apiPut("api/person/update", person,
                function (result) {
                    //alert("here is result ");
                    //  personService.personId = personId;
                    //  alert("hello" + result.data);
                    //alert("api/create/person");
                    //alert("hello");
                    //alert(person.LastName);
                    $scope.personId = result.data;
                });
            $scope.disableField();
        }


        //var test_func = function () {
        //    alert("test 1 func");
        //}


        //$scope.savePerson = function (personId) {
        //    //alert("hello personId" + personId + "   " + $scope.person);


        //    //viewModelHelper.apiPut("api/person/update/" + personId, person,
        //        viewModelHelper.apiPut("api/person/update/" + personId, null,
        //        function (result) {
        //            //   alert("here is result " + personId);
        //            //  personService.personId = personId;

        //            $scope.person = result.data;

        //            //$scope.personType = result.data;
        //            //$scope.personTypeList();
        //            ///     alert(result.data);
        //            //console.log(result.data);

        //            //alert(personId);
        //        });
        //    $scope.disableField();
        //}
        //        <script>
        //            function disableField() {
        //                document.getElementById("myFieldset").disabled = true;
        //          }

        //function undisableField() {
        //                document.getElementById("myFieldset").disabled = false;
        //          }


        //              //alert("initialize");
    });
