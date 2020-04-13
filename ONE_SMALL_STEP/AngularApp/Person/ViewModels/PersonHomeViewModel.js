app.controller("personHomeViewModel",
    function ($scope, personService, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;


        var initialize = function () {

        }

        initialize();
    });
