# NHSUK Frontend Razor - View Components Guide

This guide explains how to initialise and render the NHSUK ViewComponents.

This library is **Tag-helper focused**, meaning you can pass parameters directly as attributes in HTML (kebab-case) or as named arguments in C# (camelCase). You do not need to instantiate a full ViewModel for simple components.

## Quick Usage

### 1. Generate package

Use Visual Studio IDE to build the project to generate a package or through the console/terminal command `dotnet pack --configuration Release --output ./nupkg`

### 2. Generate package

Add relative imports at the very top of the document
* Specify the model of the component in use, e.g. `@model NHSUKFrontendRazor.ViewModels.ButtonViewModel` or `@using ButtonViewModel = NHSUKFrontendRazor.ViewModels.ButtonViewModel` if a `@model` already exists.

### 3. Initialise

#### A) Tag Helper (Recommended)

Use the `<vc:...>` syntax. Attributes correspond to the component's parameters.

* **Tag name:** `<vc:component-name />` (kebab-case). Example: `<vc:button />` or `<vc:button></vc:button>`
* **Attributes:** kebab-case. Example: `asp-controller="Home"`

```html
<vc:button text="Save" styling="Primary" asp-controller="Home" asp-action="Save"></vc:button>
```

#### B) InvokeAsync (C#)

Use `Component.InvokeAsync` with an anonymous object. Property names must match the component's parameters exactly.

```csharp
@await Component.InvokeAsync("Button", new { text = "Save", styling = ButtonStyle.Primary })
```

---

## Components Initialisation Examples

### ActionLink

* **Tag Helper:**
  ```html
  <vc:action-link link-text="Open" asp-controller="Home" asp-action="Index" asp-all-route-data="@routeData"></vc:action-link>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("ActionLink", new { linkText = "Open", aspController = "Home", aspAction = "Index", aspAllRouteData = routeData })
  ```

### BackLink

* **Tag Helper:**

```html
  <vc:back-link link-text="Back" asp-controller="Home" asp-action="Index" asp-all-route-data="@routeData"></vc:back-link>
```

* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("BackLink", new { linkText = "Back", aspController = "Home", aspAction = "Index", aspAllRouteData = routeData })
  ```

### Breadcrumbs

* **Tag Helper:**
  ```html
  <vc:breadcrumbs links="@breadcrumbsList"></vc:breadcrumbs>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Breadcrumbs", new { links = breadcrumbsList })
  ```

### Button

* **Parameters:** `text`, `style`, `styling` (Primary/Secondary/Reverse), `aspController`, `aspAction`, `aspRouteData`, `preventDoubleClick`
* **Tag Helper:**
  ```html
  <vc:button text="Continue" styling="Primary" asp-controller="Home" asp-action="Index"></vc:button>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Button", new { text = "Continue", styling = ButtonStyle.Primary, aspController = "Home", aspAction = "Index" })
  ```

### CancelLink

* **Tag Helper:**
  ```html
  <vc:cancel-link asp-controller="Home" asp-action="Index" asp-all-route-data="@routeData"></vc:cancel-link>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("CancelLink", new { aspController = "Home", aspAction = "Index", aspAllRouteData = routeData })
  ```

### Card

* **Tag Helper:**
  ```html
  <vc:card title="Card title" description="Short description" asp-controller="Home" asp-action="Details"></vc:card>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Card", new { title = "Card title", description = "Short description", aspController = "Home", aspAction = "Details" })
  ```

### CharacterCount

* **Tag Helper:**
  ```html
  <vc:character-count id="msg" label="Message" max-length="1000"></vc:character-count>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("CharacterCount", new { id = "msg", label = "Message", maxLength = 1000 })
  ```

### Checkboxes

* **Tag Helper:**
  ```html
  <vc:checkboxes label="Fruits" populate-with-current-values="true" hint-text="Select all that apply" css-class="nhsuk-checkboxes"></vc:checkboxes>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Checkboxes", new { label = "Fruits", checkboxes = checkboxOptions, populateWithCurrentValues = true })
  ```

### ContentsList

* **Tag Helper:**
  ```html
  <vc:contents-list name="On this page" list-items="@contentsItems"></vc:contents-list>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("ContentsList", new { name = "On this page", listItems = contentsItems })
  ```

### DateInput

* **Parameters:** `id`, `label`, `dayId`, `monthId`, `yearId`, `hintTextLines`, `cssClass`
* **Tag Helper:**
  ```html
  <vc:date-input id="dob" label="Date of birth" day-id="DobDay" month-id="DobMonth" year-id="DobYear"></vc:date-input>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("DateInput", new { id = "dob", label = "Date of birth", dayId = "DobDay", monthId = "DobMonth", yearId = "DobYear" })
  ```

### DateRangeInput

* **Tag Helper:**
  ```html
  <vc:date-range-input id="period" label="Period" 
      start-day-id="StartDay" start-month-id="StartMonth" start-year-id="StartYear" 
      end-day-id="EndDay" end-month-id="EndMonth" end-year-id="EndYear" 
      end-date-checkbox-id="HasEndDate" end-date-checkbox-label="Has end date">
  </vc:date-range-input>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("DateRangeInput", new { id = "period", label = "Period", startDayId = "StartDay", ... })
  ```

### Details

* **Tag Helper:**
  ```html
  <vc:details summary="Help with this section" content="<p>Detailed explanation...</p>"></vc:details>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Details", new { summary = "Help", content = "<p>Content</p>" })
  ```

### DoDontList

* **Tag Helper:**
  ```html
  <vc:do-dont-list is-do="true" rule-set='@new List<string>{"Wash hands", "Wear mask"}'></vc:do-dont-list>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("DoDontList", new { isDo = true, ruleSet = new List<string>{ "Wash hands" } })
  ```

### ErrorSummary

* **Tag Helper:**
  ```html
  <vc:error-summary order-of-property-names='@new string[]{"Email", "Password"}'></vc:error-summary>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("ErrorSummary", new { orderOfPropertyNames = new string[] { "Email" } })
  ```

### Fieldset

* **Tag Helper:**
  ```html
  <vc:fieldset title="Personal details" field-list="@fields"></vc:fieldset>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Fieldset", new { title = "Personal details", fieldList = fields })
  ```

### FileInput

* **Tag Helper:**
  ```html
  <vc:file-input asp-for="Upload" label="Upload file" hint-text="PDF only"></vc:file-input>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("FileInput", new { aspFor = "Upload", label = "Upload file", hintText = "PDF only" })
  ```

### Footer

* **Tag Helper:**
  ```html
  <vc:footer copyright="© NHS" footer-group-list="@footerGroups"></vc:footer>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Footer", new { copyright = "© NHS", footerGroupList = footerGroups })
  ```

### Hero

* **Tag Helper:**
  ```html
  <vc:hero image-src="/img/hero.jpg" heading="Welcome" text-content="Intro text"></vc:hero>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Hero", new { heading = "Welcome", textContent = "Intro text" })
  ```

### Image

* **Tag Helper:**
  ```html
  <vc:image src="/img.png" alt="Alt text" caption="A caption"></vc:image>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Image", new { src = "/img.png", alt = "Alt text" })
  ```

### InsetText

* **Tag Helper:**
  ```html
  <vc:inset-text content-html="<p>Important information</p>"></vc:inset-text>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("InsetText", new { contentHtml = "<p>Important information</p>" })
  ```

### NumericInput

* **Tag Helper:**
  ```html
  <vc:numeric-input asp-for="Age" label="Age" populate-with-current-values="true" type="number" required="true"></vc:numeric-input>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("NumericInput", new { aspFor = "Age", label = "Age", populateWithCurrentValue = true })
  ```

### Pagination

* **Tag Helper:**
  ```html
  <vc:pagination current-page="1" total-page="10" prev-url="/page/0" next-url="/page/2"></vc:pagination>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Pagination", new { currentPage = 1, totalPage = 10, prevUrl = "...", nextUrl = "..." })
  ```

### RadioList

* **Tag Helper:**
  ```html
  <vc:radio-list asp-for="Option" label="Choose option" populate-with-current-values="true" required="true"></vc:radio-list>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("RadioList", new { aspFor = "Option", label = "Choose", populateWithCurrentValues = true })
  ```

### SelectList

* **Tag Helper:**
  ```html
  <vc:select-list asp-for="Country" label="Country" value="GB" required="true"></vc:select-list>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("SelectList", new { aspFor = "Country", label = "Country", value = "GB" })
  ```

### SingleCheckbox

* **Tag Helper:**
  ```html
  <vc:single-checkbox asp-for="Agree" label="I agree to terms"></vc:single-checkbox>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("SingleCheckbox", new { aspFor = "Agree", label = "I agree" })
  ```

### SkipLink

* **Tag Helper:**
  ```html
  <vc:skip-link main-content-i-d="main-content" text="Skip to main content"></vc:skip-link>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("SkipLink", new { mainContentID = "main-content", text = "Skip to main content" })
  ```

### SummaryList

* **Tag Helper:**
  ```html
  <vc:summary-list summary-list-item="@summaryItems" has-border="true"></vc:summary-list>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("SummaryList", new { summaryListItem = summaryItems, hasBorder = true })
  ```

### Table

* **Tag Helper:**
  ```html
  <vc:table title="Data" rows="@tableRows"></vc:table>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Table", new { title = "Data", rows = tableRows })
  ```

### Tabs

* **Tag Helper:**
  ```html
  <vc:tabs title="Contents" tabs-list="@tabsList"></vc:tabs>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Tabs", new { title = "Contents", tabsList = tabsList })
  ```

### Tag

* **Tag Helper:**
  ```html
  <vc:tag name="New" styling="inprogress"></vc:tag>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("Tag", new { name = "New", styling = TagStyle.InProgress })
  ```

### TaskList

* **Tag Helper:**
  ```html
  <vc:task-list list-items="@taskItems"></vc:task-list>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("TaskList", new { listItems = taskItems })
  ```

### TextArea

* **Tag Helper:**
  ```html
  <vc:text-area asp-for="Message" label="Message" rows="5" spell-check="true" character-count="1000"></vc:text-area>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("TextArea", new { aspFor = "Message", label = "Message", rows = 5 })
  ```

### TextInput

* **Tag Helper:**
  ```html
  <vc:text-input asp-for="FirstName" label="First name" populate-with-current-value="true" type="text" required="true"></vc:text-input>
  ```
* **C# Invoke:**
  ```csharp
  @await Component.InvokeAsync("TextInput", new { aspFor = "FirstName", label = "First name", populateWithCurrentValue = true })
  ```

---

## Sample Data (C#)

Below are example data structures required for the complex components (Tabs, Tables, Lists). Define these in your PageModel or Controller.

```csharp
// Links (Breadcrumbs, SummaryList actions)
var links = new List<LinkViewModel> {
    new LinkViewModel { Text = "Home", Url = "/" },
    new LinkViewModel { Text = "Section", Url = "/section" }
};

// Checkboxes / Radios
var checkboxOptions = new List<CheckboxListItemViewModel> {
    new CheckboxListItemViewModel { AspFor = "apple", Label = "Apple" },
    new CheckboxListItemViewModel { AspFor = "banana", Label = "Banana", HintText = "Yellow" }
};

// Contents List
var contentsItems = new List<ContentsListItemViewModel> {
    new ContentsListItemViewModel { Text = "Part 1", Url = "#part1" },
    new ContentsListItemViewModel { Text = "Part 2", Url = "#part2" }
};

// Tabs
var tabsList = new List<TabViewModel> {
    new TabViewModel { Title = "Tab 1", Url = "/tab1" },
    new TabViewModel { Title = "Tab 2", Url = "/tab2" }
};

// Table Rows (List of lists)
var tableRows = new List<List<TableColumnModel>> {
    new List<TableColumnModel> {
        new TableColumnModel { Text = "Row1 Col1" },
        new TableColumnModel { Text = "Row1 Col2" }
    },
    new List<TableColumnModel> {
        new TableColumnModel { Text = "Row2 Col1" },
        new TableColumnModel { Text = "Row2 Col2" }
    }
};

// Summary List Items
var summaryItems = new List<SummaryListItemViewModel> {
    new SummaryListItemViewModel { 
        Key = "Name", 
        Value = "John Doe", 
        Actions = new [] { new LinkViewModel { Text = "Edit", Url = "/edit" } } 
    }
};

// Footer Groups
var footerGroups = new List<FooterItemGroupModel> {
    new FooterItemGroupModel {
        Title = "Support",
        Items = new [] { new FooterItemModel { Text = "Contact", Url = "/contact" } }
    }
};
```

## Customisation

The component views are located in `Views/Shared/Components`. To customize the markup of a specific component:

1. Navigate to `Views/Shared/Components/{ComponentName}/`.
2. Edit or override `Default.cshtml`.

To create a **new** component:

1. Add `ViewModels/*ViewModel.cs`
2. Add `ViewComponents/*ViewComponent.cs`
3. Add the view at `Views/Shared/Components/{ComponentName}/Default.cshtml`
