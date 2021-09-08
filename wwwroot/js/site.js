// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var menu = $(".menu");
$(window).resize(function(){
	$(".menu-toggle").removeClass("active");
	if($(window).innerWidth() > 600){
		menu.show();
	} else {
		menu.hide();
	}
});
$(".menu-toggle").click(function(){
	$(this).toggleClass("active");
	menu.slideToggle();
})
$(".open-submenu").click(function(){
	$(this).toggleClass("active");
	$(this).next("ul").slideToggle();
	$(this).children(".arrow").toggleClass("down up");
});