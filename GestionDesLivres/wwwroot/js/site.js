// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    
    $(".addlivre").click(function () {
        // Je récupère la ligne du clique
        var $row = $(this).closest("tr");
        // Je récupère les colonnes afin d'exploiter le contenu
        $tds = $row.find("td"); 
        var donnees = {
            Id: parseInt($('#'+ $tds[0].id).text()),
            title: $('#' + $tds[1].id).text(),
            contributor: $('#' + $tds[2].id).text(),
            author_name: $('#' + $tds[3].id).text(),
            author_key: $('#' + $tds[4].id).text(),
            first_publish_year: $('#' + $tds[5].id).text(),
            publisher: $('#' + $tds[6].id).text(),
        };
        $.ajax({
            url: '/Book/AddBook',
            type: 'POST',
            data: JSON.stringify(donnees), // Convertir l'objet en JSON
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                // handle success
                alert("Action called successfully");
                $(this).prop('disabled', true);
            },
            error: function (xhr, status, error) {
                // handle error
                alert("An error occurred: " + error);
            }
        });
    });
});