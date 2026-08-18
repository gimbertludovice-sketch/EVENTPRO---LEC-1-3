# C# Programming Activities — Interactive Portfolio

A single-file HTML5 website that presents three C# console programming activities
with animated terminal previews, syntax-highlighted source code, and concept
explanations for each exercise.

Built for **EVENTPRO LEC** — Bachelor of Science in Information Technology,
Specialization in Mobile and Website Development.

---

## Overview

Instead of submitting raw `.cs` files, this project wraps the activities in a
browsable web interface. Each activity page shows what the program *does*, what
the code *looks like*, and which C# concepts it *teaches* — all in one scroll.

The terminal previews replicate real console behavior, including the
character-by-character typing of user input and `Console.Clear()` screen wipes
between menu loops.

---

## Features

- **Zero dependencies** — one `index.html` file, no build step, no npm, no external CSS or JS
- **Animated terminal output** — fade-in playback for static programs, typewriter animation for interactive ones
- **Simulated user input** — green text types out character by character to show what `Console.ReadLine()` captures
- **`Console.Clear()` simulation** — the Main Menu page plays a full session (options 1 → 2 → 3 → 4) with screen wipes between each loop
- **Syntax-highlighted source** — line-numbered C# code with one-click copy
- **Concept panels** — plain-language explanation of the C# features used in each activity
- **Replay / Skip controls** — rerun any animation or jump straight to the final state
- **Hash-based routing** — deep-linkable pages (`#a1`, `#a2`, `#a3`, `#menu`) that survive a refresh
- **Keyboard navigation** — arrow keys move between pages
- **Responsive** — collapses to a burger menu and single-column layout on mobile
- **Accessible** — respects `prefers-reduced-motion`, visible focus states

---

## The Activities

| # | Activity | Concept | Key API |
|---|----------|---------|---------|
| 1 | Display Personal Info | Hardcoded string literals | `Console.WriteLine()` |
| 2 | Variables & Multiplication | Data types, arithmetic, concatenation | `int`, `string`, `*`, `+` |
| 3 | Personal Info via User Input | Runtime input capture | `Console.ReadLine()`, `Console.Write()` |
| — | Main Menu (`Program.cs`) | Loops, branching, methods | `while`, `switch`, `Console.Clear()` |

### Concept Progression

The three activities deliberately solve the same problem three ways:

1. **Static** — values baked into the compiled program
2. **Declared** — values stored in variables, one computed at runtime
3. **Dynamic** — values supplied by the user while the program runs

---

## Project Structure
├── index.html # The entire website (HTML + CSS + JS in one file)
├── Program.cs # Menu-driven launcher with typewriter effect
├── Activity1.cs # Standalone — hardcoded output
├── Activity2.cs # Standalone — variables and multiplication
└── Activity3.cs # Standalone — user input


---

## Running the Website

No server needed:

```bash
# Just open it
open index.html
```

Or use any static host — GitHub Pages, Netlify, Vercel. Since it is a single
file with no build step, drag-and-drop deployment works.

To enable **GitHub Pages**: Settings → Pages → Source: `main` branch, root folder.

---

## Running the C# Programs

```bash
dotnet run
```

`Program.cs` includes a typewriter effect built from `Thread.Sleep()` inside a
`foreach` loop over each character, plus `ConsoleColor` highlighting for
headers, errors, and the exit message.

### ⚠ Important: One Entry Point Per Project

`Activity1.cs`, `Activity2.cs`, and `Activity3.cs` each declare their own
`static void Main()`. Compiling them alongside `Program.cs` triggers compiler
error **CS0017 — Program has more than one entry point defined**.

Keep only `Program.cs` in the build and store the standalone files in a
reference folder, or exclude them in your `.csproj`:

```xml
<ItemGroup>
  <Compile Remove="Activities/**" />
</ItemGroup>
```

### Encoding Note

`Program.cs` sets `Console.OutputEncoding = System.Text.Encoding.UTF8` so that
**Biñan** renders correctly. Without it, Windows Console displays `Bi?an`.

---

## Tech Stack

- **HTML5** — semantic structure, single-file build
- **CSS3** — custom properties, Grid, Flexbox, keyframe animations
- **Vanilla JavaScript** — no framework, no libraries
- **Google Fonts** — Bebas Neue (display), Inter (body), IBM Plex Mono (code)
- **C# / .NET** — console applications

---

## Design Notes

The interface borrows event-ticket vernacular — a perforated submission pass in
the hero, barcode accents, brass-and-signal-red highlights against deep navy.
Terminal windows use a macOS-style title bar so the console output reads as a
genuine program run rather than a styled text block.

Color palette: `#1B1F3B` navy · `#F5F3EE` cream · `#E8574A` signal red ·
`#C9A227` brass · `#4FD1A5` mint (user input)

---

## Author

**Gimbert Ludovice**
2nd Year · WITMWD3M1
BS Information Technology — Mobile and Website Development

Subject: EVENTPRO LEC
Professor: Carlo Batitis

---

## License

Academic coursework. Free to reference for learning purposes.
