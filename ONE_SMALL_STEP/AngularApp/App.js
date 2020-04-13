//var commonModule = angular.module('common', ['ngRoute']);


var app = angular.module('appJS', ['ngRoute', 'ui.grid', 'ui.grid.pagination'])
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider.when('/person/create', {
            templateUrl: '/AngularApp/Person/Views/PersonCreateView.html',
            controller: 'personCreateViewModel'
        });

        $routeProvider.when('/person', {
            templateUrl: '/AngularApp/Person/Views/PersonListView.html',
            controller: 'messageTypeListViewModel'
        });

        $routeProvider.when('/person/show/:personId', {
        templateUrl: '/AngularApp/Person/Views/PersonView.html',
        controller: 'personViewModel'
        });

        $routeProvider.when('/person/create', {
        templateUrl: '/AngularApp/Person/Views/PersonCreateView.html',
        controller: 'personCreateViewModel'
        });

        $routeProvider.when('/personDetailsView', {
            templateUrl: '/AngularApp/Person/Views/PersonDetail.html',
            controller: 'mainPersonListViewModel'
        });



        //$routeProvider.when('/messageType/show/:messageTypeId', {
        //    templateUrl: '/AngularApp/Message/Views/MessageTypeView.html',
        //    controller: 'messageTypeViewModel'
        //});

        $routeProvider.when('/messagetype/create', {
            templateUrl: '/AngularApp/MessageType/Views/messageTypeCreateView.html',
            controller: 'messageTypeCreateViewModel'
        });

        $routeProvider.when('/messagetype/:messageTypeId', {
            templateUrl: '/AngularApp/MessageType/Views/MessageTypeView.html',
            controller: 'messageTypeViewModel'
        });
        $routeProvider.when('/messagetype', {
            templateUrl: '/AngularApp/MessageType/Views/MessageTypeListView.html',
            controller: 'messageTypeListViewModel'
        });

        //$routeProvider.when('/messagetype/update', {
        //    templateUrl: '/AngularApp/MessageType/Views/MessageTypeView.html',
        //    controller: 'messageTypeViewModel'
        //});



        $routeProvider.when('/message/create', {
            templateUrl: '/AngularApp/Message/Views/messageCreateView.html',
            controller: 'messageCreateViewModel'
        });

        $routeProvider.when('/message/:messageId', {
            templateUrl: '/AngularApp/Message/Views/MessageView.html',
            controller: 'messageViewModel'
        });
        $routeProvider.when('/message', {
            templateUrl: '/AngularApp/Message/Views/MessageListView.html',
            controller: 'messageListViewModel'
        });






        


        //$routeProvider.when('/customer/show/:customerId', {
        //    templateUrl: '/App/Customer/Views/CustomerView.html',
        //    controller: 'customerViewModel'
        //});

        $routeProvider.when('/', {
            templateUrl: '/AngularApp/Person/Views/MainHomeView.html',
            controller: 'mainHomeViewModel'
        });

        //$routeProvider.when('/', {
        //    templateUrl: '/App/Customer/Views/MainHomeView.html',
        //    controller: 'mainHomeViewModel'
        //});

        //$routeProvider.when('/', {
        //    templateUrl: '/AngularApp/Person/Views/mainHomeView.html',
        //    //controller: 'mainPersonListViewModel'
        //    controller: 'mainHomeViewModel'
        //})


        //$routeProvider.when('/', {
        //    templateUrl: '/AngularApp/Person/Views/mainHomeView.html',
        //    //controller: 'mainPersonListViewModel'
        //    controller: 'mainPersonListViewModel'
        //})
    //    //$routeProvider.when('/order/list', { templateUrl: '/App/Order/Views/OrderListView.html', controller: 'orderListViewModel' });
    //    //$routeProvider.when('/order/show/:orderId', { templateUrl: '/App/Order/Views/OrderView.html', controller: 'orderViewModel' });
    //    //$routeProvider.when('/order/detail/:orderId/:orderDetailId', { templateUrl: '/App/Order/Views/OrderDetailView.html', controller: 'orderDetailViewModel' });
    //    //$routeProvider.otherwise({ redirectTo: '/order' });
    //    $locationProvider.html5Mode({
    //        enabled: true,
    //        requireBase: false
    //    });
    });

//orderModule.factory('orderService', function ($rootScope, $http, $q, $location, viewModelHelper) { return MyApp.orderService($rootScope, $http, $q, $location, viewModelHelper); });

//(function (myApp) {
//    var orderService = function ($rootScope, $http, $q, $location, viewModelHelper) {

//        var self = this;

//        self.orderId = 0;

//        return this;
//    };
//    myApp.orderService = orderService;
//}(window.MyApp));












//var mainModule = angular.module('main', ['common']);

app.factory('viewModelHelper',
    function ($http, $q, $window, $location) {
        return MyApp.viewModelHelper(
            $http, $q, $window, $location);
    });

app.factory('validator', function () { return valJs.validator(); });


app.factory('messageTypeService'), function () {

    return {
            showMessageType: function (messageTypeId) {
            viewModelHelper.navigateTo("messagetype/" + messageTypeId);
        }

    }
}








app.controller("indexViewModel", function (
    $scope, $http, $q, $routeParams, $window,
    $location, viewModelHelper) {

    var self = this;

    $scope.topic =
        "COMING FROM APP.JS -- MAIN";
    $scope.author = "Richard W. Memmer";
    $scope.randomText = "Et ipsum ea sit magna facer nostrud sit vel wisi amet exerci enim eum dolore ipsum dolore voluptua ipsum erat"


    //$scope.personList = function () {
    //    

    console.log("coming from app.js indexViewModel controller")
    //refreshPersons();
    //$scope.showPersonList = false;
    //alert($scope.showPersonList);
    //viewModelHelper.navigateTo('person/list');
    //viewModelHelper.navigateTo('person/list');

});



(function (myApp) {
    var viewModelHelper = function (
        $http, $q, $window, $location) {

        var self = this;

        self.modelIsValid = true;
        self.modelErrors = [];

        self.resetModelErrors = function () {
            self.modelErrors = [];
            self.modelIsValid = true;
        }


        //Function to Delete Employee based upon id
        //this.delete = function (id) {

        //self.apiDelete = function (id) {
        //    var request = $http({
        //        method: "delete",
        //        url: uri
        //    });
        //    return request;
        //};

        //self.apiDelete = function (uri, data, success, failure, always) {
        //    self.modelIsValid = true;

        //    alert("url is " + uri + "   " + data);
        //    //$http.delete(MyApp.rootPath + uri, data)
        //    //    .then(function (result) {
        //    //        success(result);
        //    //        if (always != null)
        //    //            always();
        //    //    }, function (result) {
        //    //        if (failure != null) {
        //    //            failure(result);
        //    //        }
        //    //        else {
        //    //            var errorMessage = result.status + ':' + result.statusText;
        //    //            if (result.data != null) {
        //    //                if (result.data.Message != null)
        //    //                    errorMessage += ' - ' + result.data.Message;
        //    //                if (result.data.ExceptionMessage != null)
        //    //                    errorMessage += ' - ' + result.data.ExceptionMessage;
        //    //            }
        //    //            self.modelErrors = [errorMessage];
        //    //            self.modelIsValid = false;
        //    //        }
        //    //        if (always != null)
        //    //            always();
        //    //    });
        //    //alert(uri);
        //}

        self.apiDelete = function (uri, data, success, failure, always) {
            self.modelIsValid = true;
            //alert("delete method" + MyApp.rootPath + uri);

            $http.delete(MyApp.rootPath + uri, data)
                .then(function (result) {
                    success(result);
                    if (always != null)
                        always();
                }, function (result) {
                    if (failure != null) {
                        failure(result);
                    }
                    else {
                        var errorMessage = result.status + ':' + result.statusText;
                        if (result.data != null) {
                            if (result.data.Message != null)
                                errorMessage += ' - ' + result.data.Message;
                            if (result.data.ExceptionMessage != null)
                                errorMessage += ' - ' + result.data.ExceptionMessage;
                        }
                        self.modelErrors = [errorMessage];
                        self.modelIsValid = false;
                    }
                    if (always != null)
                        always();
                });
            //alert(uri);
        }





        self.apiGet = function (uri, data, success, failure, always) {
            self.modelIsValid = true;
            //alert("get method" + uri);
            $http.get(MyApp.rootPath + uri, data)
                .then(function (result) {
                    success(result);
                    if (always != null)
                        always();
                }, function (result) {
                    if (failure != null) {
                        failure(result);
                    }
                    else {
                        var errorMessage = result.status + ':' + result.statusText;
                        if (result.data != null) {
                            if (result.data.Message != null)
                                errorMessage += ' - ' + result.data.Message;
                            if (result.data.ExceptionMessage != null)
                                errorMessage += ' - ' + result.data.ExceptionMessage;
                        }
                        self.modelErrors = [errorMessage];
                        self.modelIsValid = false;
                    }
                    if (always != null)
                        always();
                });
            //alert(uri);
        }

        self.apiPost = function (uri, data, success, failure, always) {
            self.modelIsValid = true;
            //alert("apiPost");
            $http.post(MyApp.rootPath + uri, data)
                .then(function (result) {
                    success(result);
                    if (always != null)
                        always();
                }, function (result) {
                    if (failure != null) {
                        failure(result);
                    }
                    else {
                        var errorMessage = result.status + ':' + result.statusText;
                        if (result.data != null) {
                            if (result.data.Message != null)
                                errorMessage += ' - ' + result.data.Message;
                            if (result.data.ExceptionMessage != null)
                                errorMessage += ' - ' + result.data.ExceptionMessage;
                        }
                    }
                    if (always != null)
                        always();
                });
        }


        self.apiPut = function (uri, data, success, failure, always) {
            self.modelIsValid = true;
            //alert("put method" + MyApp.rootPath + uri + data);

            $http.put(MyApp.rootPath + uri, data)
                .then(function (result) {
                    //alert("http_put" + data);
                    success(result);
                    if (always != null)
                        always();
                    //alert("http_put 2");
                }, function (result) {
                    if (failure != null) {
                        failure(result);
                        //alert("http_put 3");
                    }
                    else {
                        var errorMessage = result.status + ':' + result.statusText;
                        alert(errorMessage);
                        if (result.data != null) {
                            if (result.data.Message != null)
                                errorMessage += ' - ' + result.data.Message;
                            if (result.data.ExceptionMessage != null)
                                errorMessage += ' - ' + result.data.ExceptionMessage;
                        }
                        self.modelErrors = [errorMessage];
                        self.modelIsValid = false;
                    }
                    if (always != null)
                        always();
                });
            //alert(errorMessage);
        }


        self.goBack = function () {
            $window.history.back();
        }

        self.navigateTo = function (path, params) {
            if (params == null)
                $location.path(MyApp.rootPath + path);
            else
                $location.path(MyApp.rootPath + path).search(params);
        }

        self.refreshPage = function (path) {
            $window.location.href = MyApp.rootPath + path;
        }

        self.clone = function (obj) {
            return JSON.parse(JSON.stringify(obj))
        }

        self.querystring = function (param) {
            if ($location.search != null)
                return $location.search()[param];
            else
                return null;
        }

        self.resetQueryParams = function () {
            $location.url($location.path());
        }

        return this;
    };
    myApp.viewModelHelper = viewModelHelper;
}(window.MyApp));

//app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
//    $routeProvider
//    when("/", { templateUrl: "/Home/Index" })
//        //.when("/", { templateUrl: "/Home/Home" })
//        .when("/contact", { templateUrl: "/Home/Contact" })
//        .otherwise({ redirectTo: "/" });

//    $locationProvider.html5Mode(false).hashPrefix("!");
//}]);
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

app.controller("MainController", MainController);

*/

//mainModule.config(function ($routeProvider,
//    $locationProvider) {
//    $routeProvider.when('/person', {
//        templateUrl: '/AngularApp/Person/Views/PersonListView.html',
//        controller: 'personListViewModel'
//    });
//    $routeProvider.when('/person/list', {
//        templateUrl: '/AngularApp/Person/Views/PersonListView.html',
//        controller: 'personListViewModel'
//    });
//    $routeProvider.when('/person/show/:personId', {
//        templateUrl: '/AngularApp/Person/Views/PersonView.html',
//        controller: 'personViewModel'
//    });


//    $routeProvider.when('/person/delete/:personId', {
//        templateUrl: '/AngularApp/Person/Views/PersonDeleteView.html',
//        //controller: 'personDeleteViewModel'
//        controller: 'personDeleteViewModel'

//    });


//    $routeProvider.when('/person/create', {
//        templateUrl: '/AngularApp/Person/Views/PersonCreateView.html',
//        controller: 'personCreateViewModel'
//    });

//    ////$routeProvider.when('/person/update/:personId', {
//    //$routeProvider.when('/person/update', {
//    //    templateUrl: '/AngularApp/Person/Views/PersonView.html',
//    //    controller: 'personViewModel'
//    //});

//    $routeProvider.when('/', {
//        templateUrl: '/AngularApp/Person/Views/mainHomeView.html',
//        //controller: 'mainPersonListViewModel'
//        controller: 'mainPersonListViewModel'
//    })


    //$routeProvider.when('/person/:personId', {
    //    templateUrl: '/AngularApp/Person/Views/PersonView.html',
    //    controller: 'personViewModel'
    //});

    //$routeProvider.otherwise({
    //    redirectTo: '/person'
    //});
    //$locationProvider.html5Mode({
    //    enabled: true,
    //    requireBase: false
    //});
//});

