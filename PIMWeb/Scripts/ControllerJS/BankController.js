(function ()
{
    var app = angular.module('PIMApp', ['ng-route']);
})();

angular.module('PIMApp',[])
.controller('BankController', function ($scope, BankService) {
    $scope.BankMaster = null;
    BankService.GetBankDetails().then(
    function (d)
    {
        $scope.BankMaster = d.data; //Success
    },
    function()
    {
        alert("Failed");//Failed
    }
    );
})
.factory('BankService', function ($http) {

    var facObj = {};
    facObj.GetBankDetails = function()
    {
        return $http.get('/Bank/GetBankDetails');
    }
    return facObj;

});

