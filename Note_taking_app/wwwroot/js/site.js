// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Get all checkboxes with the class 'linked-checkbox'
const checkboxes = document.querySelectorAll('.linked-checkbox');

    checkboxes.forEach(function(checkbox) {
        checkbox.addEventListener('change', function() {
            // Get the data-link attribute value
            const linkId = this.getAttribute('data-link');

            // Find other checkboxes with the same data-link value
            const linkedCheckboxes = document.querySelectorAll(`.linked-checkbox[data-link="${linkId}"]`);

            // Toggle the checked state for each linked checkbox
            linkedCheckboxes.forEach(function(linkedCheckbox) {
                linkedCheckbox.checked = checkbox.checked;
            });
        });
    });