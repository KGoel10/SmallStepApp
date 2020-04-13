app.controller("messageCreateViewModel",
    function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;



        var initialize = function () {

            
            $scope.getMessageType();
            $scope.getMessageType($routeParams.messageTypeId);
        }


        $scope.getMessageType = function () {
            viewModelHelper.apiGet("api/messagetype", null,
                function (result) {
                    //   alert("here is result " + personId);
                    //  personService.personId = personId;
                    //alert("hello" + result.data);
                    $scope.messageType = result.data;

                    //$scope.personTypeList();
                    ///     alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }



        $scope.cancelMessage = function () {
            viewModelHelper.navigateTo("message");
        }


        $scope.saveMessage = function () {


            var messageData = {

                  MessageTypeID: $scope.MessageTypeID
                , MessageName: $scope.MessageName
                , MessageDescription: $scope.MessageDescription
                , EmailAddress: $scope.MessageFileName
                , Screenshot: $scope.MessageLocation       



            };
            viewModelHelper.apiPost("api/message/create", messageData,
                function (result) {
                    $scope.messageTypeId = result.data;

                    viewModelHelper.navigateTo("message");

                });
        }


        initialize();

    });
