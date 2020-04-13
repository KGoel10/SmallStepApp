app.controller("messageTypeViewModel",
    function ($scope, personService, $http, $q, $routeParams, $window, $location, viewModelHelper) {

        $scope.viewModelHelper = viewModelHelper;
        $scope.personService = personService;
        $scope.personIdTEST = 0;

        $scope.pageHeading = "Message Type";

        //$scope.data = { pageHeading: "Message Type" };

        //$scope.obj = { pageHeading: null }; 
        //$scope.pageHeading = "TESTING";
        //var initialize = function () {
        //    //alert($routeParams.personId);

        //    $scope.refreshMessageType($routeParams.personId);
        //    //$scope.personTypeList();
        //}




        var initialize = function () {
            //$scope.getMessageType();
            $scope.getMessageType($routeParams.messageTypeId);
            //$scope.DISPLAY_TEST = "DISPLAY TEST MESSAGE TYPE LIST VIEW MODEL";
            //$scope.pageHeading = "Message Type List"
            //alert("initialize")
            //console.log($routeParams.messageTypeId);
        }


        $scope.getMessageType = function (messageTypeId) {
            viewModelHelper.apiGet("api/messagetype/" + messageTypeId, null,
                function (result) {
                    // alert("here is result " + personId);
                    //personService.personId = personId;

                    $scope.messageTypeId = messageTypeId;
                    $scope.messageType = result.data;
                    //console.log($scope.messageType);
                    //$scope.getPersonType();
                    $scope.disableField();
                    //alert(personId);

                    // alert(result.data);
                    //console.log(result.data);

                    //alert(personId);
                    //showMessageType();
                });
        


        //$scope.refreshMessageType = function () { 
        //    //data.pageHeading = "Message Type List"
        //    viewModelHelper.apiGet('api/messageType', null,
        //        function (result) {
        //            //$scope.customers = result.data;
        //            //alert("person list");
        //            //console.log(result.data);
        //            $scope.messageTypes = result.data;
        //            //alert("TESTING");
        //        });
        }

        initialize();




        $scope.showMessageType = function (messageTypeId) {
            viewModelHelper.navigateTo("messagetype/" + messageTypeId);
        }


        //$scope.showMessageType = function (messageTypeId) {
            
        //    //$scope.$applyAsync();
        //    //$scope.data = { pageHeading: "TESTING 22" };
        //    viewModelHelper.navigateTo("messagetype/" + messageTypeId);
        //    //$scope.data.pageHeading = "TESTING 2";
            
        //    //data.pageHeading = "Message Type";  
            
            
        //    //$scope.pageHeading = "Message Type"
        //}


        $scope.createMessageType = function () {
            viewModelHelper.navigateTo("messagetype/create");
            //$scope.disableField();
            //document.getElementById("messageTypeEdit").disabled = true;    
        }

        $scope.cancelMessageType = function () {
            viewModelHelper.navigateTo("messagetype");

        }

        $scope.deletePerson2 = function (personId) {
            alert(personId);
            viewModelHelper.apiDelete("api/person/delete/" + personId, null,
                function (result) {

            
                });
        }





       

   

        //initialize();
        //personTypeList();

        $scope.disableField = function () {
            document.getElementById("messageTypeFieldset").disabled = true;
            document.getElementById("messageTypeSave").disabled = true;
            document.getElementById("messageTypeCancel").disabled = true;            
        }

        $scope.enableField = function () {
            document.getElementById("messageTypeFieldset").disabled = false;
            document.getElementById("messageTypeSave").disabled = false;
            document.getElementById("messageTypeCancel").disabled = false;    
            document.getElementById("messageTypeDelete").disabled = true;    
            document.getElementById("messageTypeEdit").disabled = true;    
        }


        $scope.editMessageType = function () {
            $scope.enableField();

        }


        $scope.saveMessageType = function (messageType) {
    

            viewModelHelper.apiPut("api/messagetype/update", messageType,
                function (result) {
                    //alert("here is result ");
                    //  personService.personId = personId;
                    //  alert("hello" + result.data);
                    //alert("api/create/person");
                    //alert("hello");
                    //alert(person.LastName);
                    $scope.messageTypeId = result.data;
                });
            $scope.disableField();
            //$scope.$apply();
            viewModelHelper.navigateTo("messagetype");
        }




        $scope.deleteMessageType = function (messageTypeId) {
            //alert(personId);
            viewModelHelper.apiDelete("api/messagetype/delete/" + messageTypeId, null,
                function (result) {

                    // alert("here is result " + personId);
                    //personService.personId = personId;
                    //$scope.person = result.data;
                    //$scope.getPersonType();
                    //alert(personId);

                    // alert(result.data);
                    //console.log(result.data);
                    viewModelHelper.navigateTo("messagetype");
                    //alert(personId);
                });

        }

        //$scope.saveMessageType = function () {
        //    //alert("create person test");

        //    var messageTypeData = {

        //        MessageTypeName: $scope.MessageTypeName

        //    };
        //    //alert($scope.EmailAddress);
        //    //$scope.postPerson();
        //    viewModelHelper.apiPost("api/messagetype/create", messageTypeData,
        //        function (result) {
        //            $scope.messasgTypeId = result.data;

        //            //result.data = {};

        //            //$scope.MessageTypeName = '' 
        //            //$scope.MessageTypeID = ''


        //            viewModelHelper.navigateTo("messagetype");




        //        });
        //}

      
    });
