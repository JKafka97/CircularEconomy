const checkboxes = document.querySelectorAll("input[type=checkbox]");
console.log(checkboxes);
let a;

checkboxes.forEach(function (checkbox) {
  checkbox.addEventListener("change", function () {
    enabledSettings = Array.from(checkboxes) // Convert checkboxes to an array to use filter and map.
      .filter((i) => i.checked) // Use Array.filter to remove unchecked checkboxes.
      .map((i) => i.value); // Use Array.map to extract only the checkbox values from the array of objects.

    console.log(enabledSettings);
    console.log(checkbox);
    a = checkbox;
    checkbox.style.backgroundColor = "#da2128";

    myLabel = document.getElementById(checkbox.name);
    myLabel.backgroundColor = "red";
  });
});
