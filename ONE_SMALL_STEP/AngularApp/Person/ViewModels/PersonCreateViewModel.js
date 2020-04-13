app.controller("personCreateViewModel",
    function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;

        var initialize = function () {
            //alert($routeParams.personId);

            //$scope.refreshPerson($routeParams.personId);
            //$scope.createPerson();
            $scope.getPersonType();
            //$scope.savePerson();
            //$scop.savePerson();
            //alert("hello" + result.data);
            //$scope.personTypeList();
        }

        $scope.refreshPerson = function (personId) {
            viewModelHelper.apiGet("api/person/" + personId, null,
                function (result) {
                    // alert("here is result " + personId);
                    //personService.personId = personId;
                    $scope.person = result.data;
                    //$scope.getPersonType();
                    //$scope.createPerson();
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
                    //alert("hello" + result.data);
                    $scope.personType = result.data;

                    //$scope.personTypeList();
                    ///     alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }
        //initialize();

        //$scope.getPersonType = function () {
        //    viewModelHelper.apiGet("api/person/personType", null,
        //        function (result) {
        //            //   alert("here is result " + personId);
        //            //  personService.personId = personId;
        //              //alert("hello" + result.data);
        //            $scope.personType = result.data;
        //            //$scope.personTypeList();
        //            ///     alert(result.data);
        //            //console.log(result.data);

        //            //alert(personId);
        //        });
        //}


        $scope.savePerson = function () {
            //alert("create person test");

            var personData = {
                //  PersonID: $scope.PersonID
                //,
                FirstName: $scope.FirstName
                , LastName: $scope.LastName
                , EmailAddress: $scope.EmailAddress
                , Screenshot: $scope.Screenshot
                , PersonTypeID: $scope.PersonTypeID

            };
            //alert($scope.EmailAddress);
            //$scope.postPerson();
            viewModelHelper.apiPost("api/person/create", personData,
                function (result) {
                    //   alert("here is result " + personId);
                    //  personService.personId = personId;
                    //  alert("hello" + result.data);
                    //alert("api/create/person");
                    //alert("hello");
                    $scope.personId = result.data;
                    //var output = JSON.parse(result.data);
                    //$scope.personID = output.personID;
                    //$scope.personTypeList();
                    ///     alert(result.data);
                    //console.log(result.data);
                    //alert(output);
                    //alert(personId);
                    //$scope.refreshPerson(result.data);


                    //viewModelHelper.navigateTo(
                    //    'person/show/' + $scope.personId);
                    //formPersonCreateView
                    //$scope.formPersonCreateView.$se
                    result.data = {};
                    //$scope.
                    //alert("pristine 1")
                    //$scope.formPersonCreateView.$setPristine();
                    $scope.personId = ''
                    $scope.FirstName = ''
                    $scope.LastName = ''
                    $scope.EmailAddress = ''
                    $scope.Screenshot = ''
                    $scope.PersonTypeID = ''
                    //alert("pristine 2")
                    //$scope.createPerson();
                    //alert("TEST");
                    //personData = null;
                    //window.history.back();

                    //alert($scope.personId);
                    //$scope.refreshPerson($scope.personId);
                    //$scope.
                });
        }

        //$scope.createPerson = function () {
        //    viewModelHelper.navigateTo("person/create");

        //}
        //$scope.postPerson = function () {
        //    viewModelHelper.apiPost("api/person/create", personData,
        //        function (result) {
        //            //   alert("here is result " + personId);
        //            //  personService.personId = personId;
        //            //  alert("hello" + result.data);
        //            //alert("api/create/person");
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
