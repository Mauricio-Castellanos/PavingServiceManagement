# Paving Service Request and Job Management System

Dynamic Web Development - Project: Part II, Shell Setup.

An ASP.NET Core MVC course project for customers to request paving services and for staff to organize jobs. This milestone provides a working project shell, a one-page overview, two pages of requirements, and three editable wireframes.

## Run in Visual Studio

1. Open **PavingServiceManagement.sln** in Visual Studio 2022 (17.8 or newer), with the **ASP.NET and web development** workload and the .NET 8 SDK.
2. Select **PavingServiceManagement** as the startup project if needed.
3. Choose the **http** launch profile and press **Ctrl+F5**.
4. Open **http://localhost:5034** if a browser does not open automatically.

The HTTPS profile is also included; Visual Studio may ask you to trust its local development certificate. The HTTP profile is intended only for local course demonstrations.

Command-line alternative, from this project folder:

```text
dotnet restore
dotnet build
dotnet run --launch-profile http
```

If port 5034 is occupied, stop the other instance or change the port in Properties/launchSettings.json.

## What works now

- Responsive landing page, shared navigation, and service catalog.
- A typed request-form model with required fields, email/phone/length checks, and server-side validation of the selected service.
- Anti-forgery validation on form submissions.
- A successful validation demonstration with an explicit "not saved or sent" notice.
- A read-only dashboard using fictional sample records and calculated totals.
- Project-plan and prototype privacy pages.

**No database persistence, user accounts, role enforcement, job editing, or live weather API calls exist in this shell.** The requirements and wireframes describe the intended completed system. Use fictional data for testing.

## MVC code tour

| Folder/file | Purpose |
| --- | --- |
| Program.cs | Register MVC and configure the request pipeline and default route. |
| Controllers/HomeController.cs | Serve the landing page, catalog, project plan, and privacy notice. |
| Controllers/RequestsController.cs | Show the form; validate POST data; return errors or a prototype message. |
| Controllers/DashboardController.cs | Supply fictional job records to the preview. |
| Models/ServiceRequestInput.cs | Define form properties and validation attributes. |
| Models/ServiceOption.cs and JobPreview.cs | Define typed catalog and dashboard records. |
| Views/ | Razor views that render the models. |
| Views/Shared/_Layout.cshtml | Shared navigation, stylesheet, main content, and footer. |
| Services/ServiceCatalog.cs | Read-only sample catalog, to be replaced with database access later. |
| wwwroot/css/site.css | Responsive layout, typography, form, and dashboard styles. |

A browser requests /Requests/Create -> RequestsController returns the form -> Razor renders labeled inputs -> a POST binds values to ServiceRequestInput -> the controller checks ModelState -> invalid input returns errors; valid input redirects with a clearly labeled prototype message.

## Assignment documents

- **docs/Part-II-Submission.pdf**: complete seven-page assignment document.
- Page 1: system overview and objective (one page).
- Page 2: shell setup and implementation summary.
- Pages 3-4: functional user stories, acceptance criteria, non-functional requirements, access levels, and data/API design (two pages).
- Pages 5-7: service-request, staff-dashboard, and sign-in wireframes.
- **docs/Part-II-Writeup.md**: editable text, including the requirements tables.
- **docs/Paving-Wireframes.drawio**: editable wireframe shapes; open using File > Open From > Device at [diagrams.net](https://app.diagrams.net/).
- **SUBMISSION-GUIDE.md**: hand-in checklist and demo steps.
- **VERIFICATION.md**: checks actually completed.
- **REPOSITORY.md**: repository URL and sharing status.

## Planned development

1. Add EF Core with SQL Server LocalDB and migrations for customers, services, requests, jobs, and notes.
2. Add ASP.NET Core Identity with Customer, Employee, and Administrator roles.
3. Restrict records by role and ownership, including verification before linking guest requests.
4. Add create/read/update/delete operations, job assignments, scheduling, and status history.
5. Add Open-Meteo forecast lookup with explicit units, attribution, timeout handling, and caching.

The API's free endpoint is for the educational version. Recheck the provider's commercial terms before adapting the project for business use.

## Framework version

This solution targets **net8.0**, matching the installed Visual Studio 2022 and SDK. The supplied course tutorial references .NET Core 3.1. Confirm with the instructor if that exact version is mandatory. .NET Core 3.1 is retired; .NET 8 reaches end of support on November 10, 2026. A later business version should move to a supported, patched framework.

## References

- [Microsoft: Get started with ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0)
- [Microsoft: .NET support policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [Open-Meteo forecast API](https://open-meteo.com/en/docs)
- [Open-Meteo terms](https://open-meteo.com/en/terms)

The system concept follows the previously submitted Part I paving-system proposal. The project contains no real customer records or API credentials.
