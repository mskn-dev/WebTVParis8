app.controller('inscription', ['$scope','$http', function ($scope,$http) {

    $scope.valider = function (User) {
        var Utilisateur = angular.copy(User);

        $http.post('../WebServices/Utilisateurs.asmx/CreateUser', { User: Utilisateur }).
            success(function (data, status, headers, config) {
                
            }).
            error(function (data, status, headers, config) {
                
            });
    }

}]);
