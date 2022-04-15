const imgs = document.querySelectorAll('.img-select a');
const imgBtns = [...imgs];
let imgId = 1;

imgBtns.forEach((imgItem) => {
    imgItem.addEventListener('click', (event) => {
        event.preventDefault();
        imgId = imgItem.dataset.id;
        slideImage();
    });
});

function slideImage(){
    const displayWidth = document.querySelector('.img-showcase img:first-child').clientWidth;

    document.querySelector('.img-showcase').style.transform = `translateX(${- (imgId - 1) * displayWidth}px)`;
}

window.addEventListener('resize', slideImage);

// Modal Popup

let popup = document.querySelector(".popup"),
  button = document.querySelector("#popupbtn");

button.addEventListener("click", openPop);

function openPop() {
  popup.style.display = "Block";
}

window.addEventListener("click", closePop);

function closePop(e) {
  if (e.target == popup) {
    popup.style.display = "none";
  }
}



