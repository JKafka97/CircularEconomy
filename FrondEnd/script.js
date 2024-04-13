// select from html
const menuIcon = document.querySelector("header .menu-icon-container i");
const navigation = document.querySelector(".navigation-menu");
const navigationLinks = document.querySelectorAll(".menu-item");

// function which replace the hamburger and cross icon
function replaceClass(element, oldClass, newClass) {
  element.classList.remove(oldClass);
  element.classList.add(newClass);
}

// open and close navigation
let hiddenNav = true;
menuIcon.addEventListener("click", () => {
  if (hiddenNav) {
    navigation.style.display = "block";
    replaceClass(menuIcon, "fa-bars", "fa-xmark");
    hiddenNav = false;
  } else {
    navigation.style.display = "none";
    replaceClass(menuIcon, "fa-xmark", "fa-bars");
    hiddenNav = true;
  }
});

// close the navigation after click any link
navigationLinks.forEach((navLink) =>
  navLink.addEventListener("click", () => {
    navigation.style.display = "none";
    replaceClass(menuIcon, "fa-xmark", "fa-bars");
    hiddenNav = true;
  })
);

// choice tag and process !!
const foodSearch = document.getElementById("potraviny-prozkoumat");
const homeSearch = document.getElementById("domacnost-prozkoumat");
const textilSearch = document.getElementById("textil-prozkoumat");

let choiceMainPage = "";

foodSearch.addEventListener("click", () => {
  choiceMainPage += "food-search";
});
homeSearch.addEventListener("click", () => {
  choiceMainPage += "home-search";
});
textilSearch.addEventListener("click", () => {
  choiceMainPage += "textil-search";
});

// let choiceSecondPage = "";
