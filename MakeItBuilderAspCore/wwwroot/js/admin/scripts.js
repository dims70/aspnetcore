//Переход по пунктам меню
$('.sidenav>li>a').on('click', (e) => {
    $('.sidenav > .active').removeClass('active');
    $(e.target).parent('li').addClass('active')
})
//Клик на пункт настройки
$('#settings').on('click', async () => {
    let response = await fetch('/Admin/Settings');
    if (response.ok) {
        $('#content-main').html(await response.text())
    }
    else {
        $('#content-main').html('Ошибка загрузки.')
    }
})
    //Смена темы
$('#content-main').on('click', '.changetheme', (e) => {
    $('html').attr('theme', $(e.target).attr('value'));
    document.cookie = `theme=${$(e.target).attr('value')}`
})
