eventModule.controller("eventController", function ($scope, EventsService) {
    EventsService.getTalks().then(function (talks) { $scope.talks = talks }, function ()
    { alert('error while fetching talks from server') })
    $scope.update = function () {
        $scope.talks[0].name = "New text Updated";
    };
    $scope.editDuration = false;
    $scope.ShowEdit = function () {
        $scope.editDuration = true;
    };
    $scope.HideEdit = function () {
        $scope.editDuration = false;
    };
    $scope.deleteItem = function (index) {
        $scope.talks.splice(index, 1);
    };
    $scope.TotalDuration = function () {
        var sumofDuration = 0;
        for (var i in $scope.talks) {
            sumofDuration += parseInt($scope.talks[i].duration);
        }
        return sumofDuration;
    };
});
