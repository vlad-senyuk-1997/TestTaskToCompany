angular.module('TestTask', [])
.controller('TestCtrl', function($scope, $http) {
    $http.get('http://localhost:60380/api/Default/').
        then(function (response) {
            $scope.stores = response.data;
        });

    $scope.products = function (sId) {
        $http.get('http://localhost:60380/api/Default/' + sId).
            then(function (response) {
                $scope.productsArray = response.data;
            });
    }
});
