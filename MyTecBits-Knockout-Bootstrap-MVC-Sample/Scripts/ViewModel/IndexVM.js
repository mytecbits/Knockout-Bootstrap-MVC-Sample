var urlPath = window.location.pathname;

$(function () {
    ko.applyBindings(indexVM);
    indexVM.loadArticles();
});

var indexVM = {
    Articles: ko.observableArray([]),

    loadArticles: function () {
        var self = this;
        //Ajax Call Get All Articles
        $.ajax({
            type: "GET",
            url: urlPath + '/FillIndex',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Articles(data); //Put the response in ObservableArray
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });

    }
};

function Articles(Articles) {
    this.Title = ko.observable(Articles.Title);
    this.Excerpts = ko.observable(Articles.Excerpts);
    this.Content = ko.observable(Articles.Content);
}