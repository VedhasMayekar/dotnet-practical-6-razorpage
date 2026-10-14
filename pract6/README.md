# Practical 6 — Razor Pages Student Registration

**Aim:** Use forms for user input and data submission.

- Create a Student Registration Form using Razor Pages.
- Bind form inputs to a model.
- Implement client-side and server-side validation using Data Annotations.
- Show a success page after a valid registration.

## Run

Open `pract6.csproj` in Visual Studio 2026 with the .NET 8 SDK and run. The root URL redirects to `/StudentView`.

## Validation

The Student model uses `Required`, `StringLength`, `Range`, `EmailAddress`, and `RegularExpression` attributes. Invalid submissions return to the form with validation messages.

Note: the journal's sample page model validates the submission and redirects to a success page; it does not show database persistence code.
