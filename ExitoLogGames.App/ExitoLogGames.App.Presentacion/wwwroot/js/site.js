// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let slider_index = 0;

function showSlide(index){
    let slides = document.querySelectorAll('.slide');
    if(index >= slides.length)slider_index=0;
    if(index < 0) slider_index = slides.length-1;
    for(let i = 0; i<slides.length;i++){
        slides[i].style.display="none";
        slides[i].classList.remove("slide-next");
    }

    slides[slider_index].style.display="block";
    slides[slider_index].classList.add("slide-prev");
    console.log(slider_index)

}

showSlide(slider_index);

document.getElementById("bfr").onclick=()=>{
    showSlide(--slider_index);
}
document.getElementById("nxt").onclick=()=>{
    showSlide(++slider_index);
}
setInterval(()=>{showSlide(++slider_index)},3000);