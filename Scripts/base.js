var apiUrl = '/api/users';

$(document).ready(function () {
    $.getJSON(apiUrl).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: formatItem(item) }).appendTo($('#users'));
        })
    });
})

function formatItem(item) {
    return item.Username + ':' + item.Age;
}

function AddUser()
{
    var name = $('#name').val();
    var age = $('#age').val();
    var location = $('#location').val();
    var param = { username: name, age: age, location: location };
    $.post(apiUrl, param).done(function (data) {
       // alert(data);
    });
}