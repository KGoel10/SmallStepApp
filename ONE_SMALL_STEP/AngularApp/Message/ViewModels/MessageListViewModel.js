

app.controller("messageListViewModel", function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

    $scope.viewModelHelper = viewModelHelper;
    //$scope.personService = personService;

    var initialize = function () {
        $scope.getMessageList();
        //$scope.DISPLAY_TEST = "DISPLAY TEST MESSAGE TYPE LIST VIEW MODEL";
        //$scope.pageHeading = "Message Type List"
        //alert("initialize")
    }

    $scope.getMessageList = function () {
        viewModelHelper.apiGet('api/message', null,
            function (result) {

                $scope.messages = result.data;
                //console.log($scope.messages);

            });
    }

    initialize();



    $scope.deleteMessageFromList = function (idx) {
        var messageToDelete = $scope.messages[idx];
        console.log(messageToDelete);
        $scope.messages.splice(idx, 1);
        //$scope.deletePerson2({ personId: personToDelete.personId }); CHECK ON THIS -- DON'T FOLLOW IT!!

        $scope.deleteMessage(messageToDelete.MessageID);
        //$scope.deleteMessageType(messageTypeIDToDelete);


    }


    $scope.createMessage = function () {
        viewModelHelper.navigateTo("message/create");
    }


    $scope.deleteMessage = function (messageId) {
        //alert(personId);
        viewModelHelper.apiDelete("api/message/delete/" + messageId, null,
            function (result) {
 
            });

        //viewModelHelper.navigateTo('person/list');


    }

    //showMessageType
    $scope.showMessage = function (messageId) {

        //$scope.$applyAsync();
        //$scope.data = { pageHeading: "TESTING 22" };
        viewModelHelper.navigateTo("message/" + messageId);
        //$scope.data.pageHeading = "TESTING 2";

        //data.pageHeading = "Message Type";  


        //$scope.pageHeading = "Message Type"
    }





});
