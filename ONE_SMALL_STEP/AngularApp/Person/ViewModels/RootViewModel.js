

app.controller("rootViewModel",
    function ($scope, personService, $http, viewModelHelper) {
        //personModule.controller("rootViewModel",
        //function ($scope, $http) {

        // This is the parent controller/viewmodel for 'personModule' and its $scope is accesible
        // down controllers set by the routing engine. This controller is bound to the 
        //Index.cshtml in the Person view-folder.

        $scope.TEST_FROM_ROOT_VIEW_MODEL = "test from root view model";
        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;

        $scope.flags = { shownFromList: false };

        //var initialize = function () {
        //    $scope.pageHeading = "Person Section";
        //    //$scope.personHomeText = "PersonViewModel.js TEST TEXT"
        //    }


        $scope.personList = function () {
            viewModelHelper.navigateTo('person/list');
            //alert("nagigate to person/list");
        }


        //$scope.showPerson = function () {
        //    alert("test");
        //        if (personService.personId != 0) {
        //$scope.flags.shownFromList = false;
        //viewModelHelper.navigateTo(
        //                'person/show/' + personService.personId);
        //            //alert(personService.personId);
        //    };  

        //}
        //$scope.showPerson = function (personId) {
        //    viewModelHelper.navigateTo("person/show/" + personId);
        //}


        $scope.deletePersonView = function (personId) {
            //alert("GOTO deletePersonView: " + personId);
            if (personId != 0) {
                // $scope.flags.shownFromList = false;
                //alert("hello");
                viewModelHelper.navigateTo(
                    'person/delete/' + personId);
                //alert(personService.personId);
            };

        }

        $scope.createPerson = function () {
            //alert("nagigate to person/create");
            viewModelHelper.navigateTo('person/create');
            //alert("person/create");

        }

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
        }


        //initialize();
        //alert("initialize");
    });

