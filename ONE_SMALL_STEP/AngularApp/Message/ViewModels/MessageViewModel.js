app.controller("messageViewModel",
    function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        //$scope.personService = personService;
        //$scope.personIdTEST = 0;

        $scope.pageHeading = "Message";

  
        var initialize = function () {
            //$scope.getMessage();
            $scope.getMessage($routeParams.messageId);
            
        }


        //$scope.getMessage = function (messageTypeId) {
        //    viewModelHelper.apiGet("api/message/" + messageId, null,
        //        function (result) {
        //            // alert("here is result " + personId);
        //            //personService.personId = personId;

        //            $scope.messageTypeId = messageTypeId;
        //            $scope.messageType = result.data;
        //            //console.log($scope.messageType);
        //            //$scope.getPersonType();
        //            $scope.disableField();
  
        //        });


        //}


        $scope.getMessage = function (messageId) {
            viewModelHelper.apiGet("api/message/" + messageId, null,
                function (result) {
                    // alert("here is result " + personId);
                    //personService.personId = personId;
                    console.log(messageId);

                    $scope.messageId = messageId;
                    $scope.message = result.data;
                    $scope.getMessageType();
                    $scope.disableField();
                    //alert(personId);

                    // alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }


        $scope.getMessageType = function () {
            viewModelHelper.apiGet("api/messagetype", null,
                function (result) {
                    //   alert("here is result " + personId);
                    //  personService.personId = personId;
                    //  alert("hello" + result.data);
                    $scope.messageType = result.data;
                    //$scope.personTypeList();
                    ///     alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                });
        }

        //$scope.getMessageType = function (messageTypeId) {
        //    viewModelHelper.apiGet("api/messagetype/" + messageTypeId, null,
        //        function (result) {
        //            // alert("here is result " + personId);
        //            //personService.personId = personId;

        //            $scope.messageTypeId = messageTypeId;
        //            $scope.messageType = result.data;
        //            //console.log($scope.messageType);
        //            //$scope.getPersonType();
        //            //$scope.disableField();
        //            //alert(personId);

        //            // alert(result.data);
        //            //console.log(result.data);

        //            //alert(personId);
        //            //showMessageType();
        //        });

        //}


        initialize();




        $scope.showMessageType = function (messageTypeId) {
            viewModelHelper.navigateTo("message/" + messageTypeId);
        }


        $scope.createMessageType = function () {
            viewModelHelper.navigateTo("message/create");
            //$scope.disableField();
            //document.getElementById("messageTypeEdit").disabled = true;    
        }

        $scope.cancelMessage = function () {
            viewModelHelper.navigateTo("message");

        }


        //initialize();
        //personTypeList();

        $scope.disableField = function () {
            document.getElementById("messageFieldset").disabled = true;
            document.getElementById("messageSave").disabled = true;
            document.getElementById("messageCancel").disabled = true;
        }

        $scope.enableField = function () {
            document.getElementById("messageFieldset").disabled = false;
            document.getElementById("messageSave").disabled = false;
            document.getElementById("messageCancel").disabled = false;
            document.getElementById("messageDelete").disabled = true;
            document.getElementById("messageEdit").disabled = true;
        }


        $scope.editMessage= function () {
            $scope.enableField();

        }


        $scope.saveMessage = function (message) {


            viewModelHelper.apiPut("api/message/update", message,
                function (result) {
 
                    $scope.messageId = result.data;
                });
            $scope.disableField();
            viewModelHelper.navigateTo("message");
        }




        $scope.deleteMessage = function (messageId) {
            viewModelHelper.apiDelete("api/message/delete/" + messageId, null,
                function (result) {           
                    viewModelHelper.navigateTo("message");    
                });

        }



    });
