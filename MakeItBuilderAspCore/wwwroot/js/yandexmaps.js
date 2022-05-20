/**
 * Yandex Suggest API
 */

$(function () {
    var timer = null
        , timeout = 800;

    $('#suggest').on('keyup', function () {
        var value = $(this).val();

        clearTimeout(timer);

        timer = setTimeout(function () {
            var $suggest = $('#suggest')
                , $results = $('#suggest-results').removeClass('visible').empty()
                , $close = $('#suggest-close');

            // is empty value
            if ($.trim(value) === '') {
                return false;
            }

            var $ul = $('<ul/>').appendTo($results);

            ymaps.suggest(value)
                .then(function (items) {
                    $results.addClass('visible');
                    $close.addClass('visible');
                    let $searchIcon = $(`
                        <img src="../img/icons/location.svg" height=15 width=15>`);
                    if (items.length > 0) {
                        $.each(items, function (_, adress) {
                           
                            $ul.append(`<li>${$searchIcon[0].outerHTML} <span>${adress.value}</span></li>`);
                            //$ul.append($('<li/>').append($searchIcon).append(this.value));
                        });

                        $('li', $results).on('click', function () {
                            $suggest.val($(this).text().trim());
                            $results.removeClass('visible');
                            setTimeout(() => $results.empty(), 801);
                        });
                    } else {
                        $ul.append($('<li/>').addClass('message').text('Ничего не найдено'));
                    }

                    $close.on('click', function () {
                        $suggest.val($(this).text().trim());
                        $results.empty();
                        $results.removeClass('visible');
                        $close.removeClass('visible');
                        timer = null;
                    });
                })
                .catch(function (err) {
                    throw err;
                });
        }, 800);
    });
});


