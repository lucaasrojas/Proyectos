// Barra de navegacion pegajosa al bajar

$(document).ready(function(){
	var altura = $('.menu').offset().top;
	
	$(window).on('scroll', function(){
		if ( $(window).scrollTop() > altura){
			$('.menu').addClass('menu-fixed');

		}else{
			$('.menu').removeClass('menu-fixed');
		}

	});

});

// Flecha de ir arriba

$(document).ready(function(){

	$('.ir-arriba').click(function(){
		$('body, html').animate({scrollTop: '0px'});

	});

	$(window).scroll(function(){
		if ( $(this).scrollTop() > 0 ){
			$('.ir-arriba').slideDown(300);
		}else{
			$('.ir-arriba').slideUp(500);
		};

	});

});