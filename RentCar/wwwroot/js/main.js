// ==================== HAMBURGER MENU ====================

const hamburger = document.querySelector(".hamburger");
const navLinks = document.querySelector(".nav__links");
const links = document.querySelectorAll(".nav__links li");

hamburger.addEventListener('click', ()=>{
   //Animate Links
    navLinks.classList.toggle("open");
    links.forEach(link => {
        link.classList.toggle("fade");
    });

    //Hamburger Animation
    hamburger.classList.toggle("toggle");
});


// ==================== CLICK SOUND EFFECT ====================

var bleep = new Audio();
bleep.src = "./audio/sound.wav";


// ==================== ACCORDION AND DARK MODE ====================

const accordionItemHeaders = document.querySelectorAll(".accordion-item-header");

window.onload = () => {
    accordionItemHeaders.forEach(accordionItemHeader => {
        accordionItemHeader.addEventListener("click", event => {
            const currentlyActiveAccordionItemHeader = document.querySelector(".accordion-item-header.active");
            if (currentlyActiveAccordionItemHeader && currentlyActiveAccordionItemHeader !== accordionItemHeader) {
                currentlyActiveAccordionItemHeader.classList.toggle("active");
                currentlyActiveAccordionItemHeader.nextElementSibling.style.maxHeight = 0;
            }

            accordionItemHeader.classList.toggle("active");
            const accordionItemBody = accordionItemHeader.nextElementSibling;
            if (accordionItemHeader.classList.contains("active")) {
                accordionItemBody.style.maxHeight = accordionItemBody.scrollHeight + "px";
            } else {
                accordionItemBody.style.maxHeight = 0;
            }
        });
    });

    // dark mode
    const checkbox = document.getElementById('checkbox');

    checkbox.addEventListener('change', () => {
        // change the theme of the website
        document.body.classList.toggle('dark');
    });

    
}

// ==================== PAYMENT ====================

var urchoice = document.getElementById('payment-method')

function chosePaymentMethod(method) {
    urchoice.value = method
    return
}

