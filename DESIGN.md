---
name: CloudZen
description: Personal cloud consulting showcase — empowering, minimal, practical.
colors:
  teal-brand: "#61C2C8"
  teal-hover: "#74b7bb"
  teal-light: "#76cbd2"
  cta-orange: "#F0642A"
  cta-orange-hover: "#E25A1F"
  teal-50: "#DAF6F9"
  teal-100: "#B8EFF4"
  teal-200: "#89D6DC"
  teal-300: "#78BCC2"
  teal-400: "#659FA5"
  teal-500: "#538488"
  teal-600: "#40676B"
  teal-700: "#2F4E51"
  teal-800: "#1F3638"
  teal-900: "#0F1E1F"
  teal-950: "#081314"
  surface-white: "#ffffff"
  surface-subtle: "#f9fafb"
  surface-muted: "#f3f4f6"
  ink-heading: "#1f2937"
  ink-body: "#374151"
  ink-muted: "#6b7280"
  ink-faint: "#9ca3af"
  border-default: "#e5e7eb"
  border-accent: "#89D6DC"
  focus-ring: "#40676B"
typography:
  display:
    fontFamily: "IBM Plex Sans, Arial, Helvetica, sans-serif"
    fontSize: "clamp(2.25rem, 5vw, 3.75rem)"
    fontWeight: 700
    lineHeight: 1.05
    letterSpacing: "-0.02em"
  headline:
    fontFamily: "IBM Plex Sans, Arial, Helvetica, sans-serif"
    fontSize: "clamp(1.5rem, 3vw, 2.25rem)"
    fontWeight: 700
    lineHeight: 1.2
    letterSpacing: "-0.015em"
  title:
    fontFamily: "IBM Plex Sans, Arial, Helvetica, sans-serif"
    fontSize: "1.25rem"
    fontWeight: 600
    lineHeight: 1.3
    letterSpacing: "-0.01em"
  body:
    fontFamily: "Helvetica Neue, Helvetica, Arial, sans-serif"
    fontSize: "1rem"
    fontWeight: 400
    lineHeight: 1.65
    letterSpacing: "normal"
  label:
    fontFamily: "IBM Plex Sans, Arial, Helvetica, sans-serif"
    fontSize: "0.875rem"
    fontWeight: 600
    lineHeight: 1.4
    letterSpacing: "0.01em"
  caption:
    fontFamily: "Helvetica Neue, Helvetica, Arial, sans-serif"
    fontSize: "0.75rem"
    fontWeight: 400
    lineHeight: 1.5
    letterSpacing: "0.01em"
rounded:
  sm: "4px"
  md: "8px"
  lg: "12px"
  xl: "16px"
  "2xl": "1rem"
  full: "9999px"
spacing:
  xs: "4px"
  sm: "8px"
  md: "16px"
  lg: "24px"
  xl: "32px"
  "2xl": "48px"
  "3xl": "64px"
components:
  button-primary:
    backgroundColor: "{colors.cta-orange}"
    textColor: "{colors.teal-900}"
    rounded: "{rounded.full}"
    padding: "12px 28px"
    note: "Deep teal ink (#0F1E1F) on Ember orange (#F0642A) — about 5.3:1, WCAG AA pass"
  button-primary-hover:
    backgroundColor: "{colors.cta-orange-hover}"
  button-secondary:
    backgroundColor: "{colors.surface-white}"
    textColor: "{colors.ink-body}"
    rounded: "{rounded.full}"
    padding: "10px 24px"
  button-secondary-hover:
    backgroundColor: "{colors.teal-50}"
    textColor: "{colors.teal-600}"
  card:
    backgroundColor: "{colors.surface-white}"
    rounded: "{rounded.2xl}"
    padding: "{spacing.xl}"
  input:
    backgroundColor: "{colors.surface-subtle}"
    textColor: "{colors.ink-body}"
    rounded: "{rounded.xl}"
    padding: "12px 16px"
  input-focus:
    backgroundColor: "{colors.surface-white}"
---

# Design System: CloudZen

## 1. Overview

**Creative North Star: "The Working Prototype"**

CloudZen's design system communicates capability through craft. Every surface, transition, and typographic decision is evidence of technical judgment — the kind a client or collaborator evaluates before they read a single word of copy. The system is built, not polished: it shows process (a workflow illustration, staged reveals) rather than announcing results. Motion is structural, not decorative. Spacing is deliberate, not generous by default.

The palette is a tonal progression from near-black deep teal to crisp white, anchored by a warm cyan brand accent (`#61C2C8`) and a single high-energy orange for primary calls to action (`#F0642A`). These two chromatic notes — cool technical teal and energetic warm orange — create a controlled tension that reads as competent and approachable at the same time.

This system explicitly rejects: stock-heavy corporate CV layouts, aggressive salesy CTAs, dated gradient overlays, the "black box" agency feel of opaque process descriptions, and disconnected section-to-section transitions that make a page feel assembled rather than designed. No warm cream backgrounds (`#fcf9f5` and equivalents) anywhere, including the hero (now white) — the surface is white or the lightest step of the teal scale, never a warm-neutral tint.

**Key Characteristics:**
- Tonal depth via color ramp steps, not pervasive box-shadows
- Orange CTAs only; teal is for accents, links, focus, and decoration — never primary actions
- IBM Plex Sans for all display/heading copy; Helvetica Neue for all body prose
- Motion as flow: elements animate in sequence, not in unison
- Technical warmth: precision of a well-built component, human enough to invite contact

---

## 2. Colors: The Deep Signal Palette

A cool, precise ramp from near-black teal through crisp white, accented by a single warm orange reserved exclusively for primary actions. The palette earns its restraint; the orange CTA is the only warm note on any screen that uses a white surface.

### Primary
- **Aqua Signal** (`#61C2C8`): Brand accent. Icon fills, focus rings, hover borders, validation highlights, and animated connector paths. Not used on text body. Not used as a primary CTA button.
- **Deep Signal Teal** (`#40676B` / `teal-600`): Primary accent on dark-safe surfaces — links, active nav states, inline highlights, accent decorative lines. Passes 4.5:1 on white.
- **Ink Teal** (`#2F4E51` / `teal-700`): Paragraph text on white and subtle surfaces.
- **Heading Teal** (`#1F3638` / `teal-800`): Card titles, section headings that live on tinted surfaces.

### Secondary
- **Ember Orange** (`#F0642A`): All primary CTA buttons. Only warm color on light surfaces. Used nowhere else (no headings, no borders, no backgrounds except intentional highlight spots). **CTA button text must use deep teal ink (`#0F1E1F` / `text-teal-cyan-aqua-900`) — not white — to pass WCAG AA (about 5.3:1 on #F0642A; 4.6:1 on hover #E25A1F).**
- **Ember Hover** (`#E25A1F`): Pressed/hover state for Action Orange.

### Tertiary
- **Teal Mist** (`#DAF6F9` / `teal-50`): Icon backgrounds, badge fills, section tints. Always paired with a teal-600 or teal-700 element.
- **Teal Haze** (`#89D6DC` / `teal-200`): Hover borders, header scroll accent line.

### Neutral
- **Surface White** (`#ffffff`): Default card and page surface.
- **Subtle Gray** (`#f9fafb`): Alternate section backgrounds.
- **Muted Gray** (`#f3f4f6`): Input backgrounds at rest.
- **Border Default** (`#e5e7eb`): Card and input borders at rest.
- **Ink Heading** (`#1f2937`): Top-level headings on white surface.
- **Ink Body** (`#374151`): Paragraph text on white. 7.4:1 contrast. Never use anything lighter than this for body prose.
- **Ink Muted** (`#6b7280`): Secondary info, metadata — only for text ≥ 14px at weight ≥ 600.
- **Ink Faint** (`#9ca3af`): Nav underlines, decorative dividers only. Never for readable text.

### Dark Surfaces
- **Deep Teal** (`#0F1E1F` / `teal-900`) → `#1F3638` (`teal-800`): Dark sidebar and dark section gradient. Use with `teal-100`/`teal-200` text.

### Named Rules
**The Orange Monopoly Rule.** Orange appears on one element per screen: the primary CTA button. If a second orange element is needed, reconsider the hierarchy before adding it.

**The Teal Contrast Rule.** Body text on white must use `teal-700` (#2F4E51) or `ink-body` (#374151) at minimum. Teal-600 (#40676B) is the lightest permitted value for body-weight text; never use teal-500 or above for prose on white.

---

## 3. Typography

**Display Font:** IBM Plex Sans (Arial, Helvetica, sans-serif fallback)  
**Body Font:** Helvetica Neue (Helvetica, Arial, sans-serif fallback)  
**Label Font:** IBM Plex Sans (same as display)

**Character:** IBM Plex Sans brings engineering precision — tight tracking at large sizes, confident weight contrast — without the coldness of a purely geometric sans. Helvetica Neue in body keeps reading comfortable and neutral. Together they read as "built by someone technically capable who also knows how to communicate."

### Hierarchy

- **Display** (700, `clamp(2.25rem, 5vw, 3.75rem)`, lh 1.05, tracking −0.02em): Hero headlines and major section openers. Maximum one per view. Use `text-wrap: balance`. Never exceed 3.75rem (≈ 60px).
- **Headline** (700, `clamp(1.5rem, 3vw, 2.25rem)`, lh 1.2, tracking −0.015em): Section headings, card group headers. Use `text-wrap: balance` on lines shorter than 30ch.
- **Title** (600, `1.25rem`, lh 1.3, tracking −0.01em): Individual card titles, step labels, feature names.
- **Body** (400, `1rem`, lh 1.65): All prose. IBM Plex body font family (`Helvetica Neue`). Constrain line length to 65–72ch in reading-focused sections.
- **Label** (600, `0.875rem`, lh 1.4, tracking 0.01em): Button text, nav links, badge copy, short field labels. IBM Plex.
- **Caption** (400, `0.75rem`, lh 1.5): Metadata, timestamps, secondary stat labels.

### Named Rules
**The Two-Family Rule.** IBM Plex Sans for anything structural or named (headings, labels, buttons). Helvetica Neue for anything read continuously (body, descriptions, quotes). No third family.

**The Uppercase Restriction.** All-caps is allowed only on labels ≤ 4 words at caption size (`0.75rem`) with explicit letter-spacing ≥ `0.08em`. No all-caps headings, no all-caps body copy.

---

## 4. Elevation

CloudZen uses **tonal elevation** as the primary depth system: surfaces are differentiated by color step (white → subtle gray → teal-50 → teal-100 → dark teal) rather than stacked box-shadows. Shadows are ambient and state-driven, not structural.

### Shadow Vocabulary

- **Rest (none)**: Default card state on white surface. `border: 1px solid #e5e7eb` provides the boundary. No box-shadow.
- **Ambient-low** (`0 2px 8px rgba(0,0,0,0.08), 0 1px 3px rgba(0,0,0,0.04)`): Small floating elements (chat greeting bubble, compact badges).
- **Ambient-mid** (`0 4px 16px rgba(0,0,0,0.10)`): Modals, dropdowns, badges that float over content.
- **Hover-soft** (`0 10px 30px -15px rgba(64,103,107,0.22)`): Cards on hover (ServiceCard, Core Solutions, CaseStudies, ProjectCard). Teal-tinted, negative spread, no vertical movement. Applied via `transition-[border-color,box-shadow] duration-300`.
- **No glows.** Zero-offset colored glow shadows (teal or orange) are retired; do not add them. Highlight state with a border or flat tint instead.
- **CTA-button** (`0 1px 2px rgba(15,30,31,.14), 0 2px 6px -2px rgba(15,30,31,.18)`): Flat, offset, ink-tinted shadow on the CTA. No colored glow, no hover growth.

### Named Rules
**The Flat-by-Default Rule.** Cards and containers have no box-shadow at rest — only a `1px border-gray-100` boundary and a background tint distinguishing them from the page surface. Shadows activate exclusively on hover, focus, or explicit "elevated" state.

---

## 5. Components

### Buttons

Technical and warm: rounded-full silhouette (approachable), precise internal padding (deliberate), immediate hover feedback (responsive).

- **Shape:** `border-radius: 9999px` (`rounded-full`)
- **Primary (Ember Orange, `.btn-cta`):** `background: #F0642A; color: #0F1E1F; padding: 0.75rem 1.75rem; font: 600 0.875rem IBM Plex Sans; letter-spacing: 0.01em`. Single source of truth for every CTA; no gradient, no shimmer sheen.
- **Primary Hover/Active/Focus:** hover `background: #E25A1F`; active `translateY(1px)`; focus-visible `outline: 2px solid #0F1E1F; outline-offset: 3px`. Transitions 0.12–0.18s ease-out on color, shadow and transform only.
- **Secondary (Ghost):** `background: #fff; color: #374151; border: 2px solid #e5e7eb; padding: 0.625rem 1.5rem`
- **Secondary Hover:** `background: #DAF6F9; color: #40676B; border-color: #78BCC2`
- **Text Link:** `color: #40676B; text-decoration: underline 1px currentColor; underline-offset: 3px`
- **Focus ring:** `outline: 2px solid #40676B; outline-offset: 3px`

### Cards / Containers

- **Corner Style:** `border-radius: 1rem` (`rounded-2xl` = 16px) for standard cards; `rounded-xl` (12px) for compact cards and icon tiles
- **Background:** `#ffffff` on gray-50/100 page surface; `teal-50` for tinted feature cards
- **Border:** `1px solid #e5e7eb` at rest; `border-color: #89D6DC` on hover
- **Shadow Strategy:** None at rest (flat-by-default); `hover-soft` shadow on interactive hover
- **Internal Padding:** `1.5rem` standard; `0.875rem 1.25rem` for compact cards
- **Hover:** `border-color: #89D6DC` plus the `hover-soft` shadow; no `translateY`, no top accent bar. `transition: border-color, box-shadow 0.3s ease-out`

### Inputs / Fields

- **Style:** `background: #f9fafb; border: 1px solid #e5e7eb; border-radius: 0.75rem; padding: 0.75rem 1rem`
- **Focus:** `background: #fff; outline: none; ring: 2px solid #40676B; border-color: transparent`
- **Validation (invalid):** `outline: 1px solid #61C2C8`
- **Validation message:** `color: #40676B; font-size: 0.75rem; margin-top: 0.25rem`
- **Disabled:** `opacity: 0.5; cursor: not-allowed`

### Chips / Badges

- **Section badge:** `background: #DAF6F9; color: #40676B; font: 600 0.875rem IBM Plex Sans; padding: 0.375rem 1rem; border-radius: 9999px`
- **Status badge:** Same shape with contextual tint (teal-50/teal for neutral; `bg-orange-50 text-orange-600` for highlighted)
- **Inverted (on dark):** `background: rgba(255,255,255,0.12); color: #B8EFF4; backdrop-filter: blur(4px)`

### Navigation

- **Default:** `color: #374151; font: 500 0.9375rem IBM Plex Sans; text-decoration: none`
- **Hover:** animated underline expanding from center (width 0 → 100%, `transition: 0.25s cubic-bezier(0.4,0,0.2,1)`)
- **Active:** `color: #61C2C8` with persistent underline in `#9ca3af`
- **Scrolled state:** header gains `background: rgba(255,255,255,0.85); backdrop-filter: blur(12px); border-bottom: 1px solid #d1d5db`
- **Mobile:** slide-down menu (`animation: slide-down 0.25s cubic-bezier(0.4,0,0.2,1)`) with hamburger → X icon morph

### Signature Component: Hero Illustration Panel

The hero's right half is a white panel holding one raster illustration of an AI automation workflow (`/images/hero-ai-illustration.png`, 640x427, eager-loaded), placed over a faint teal dot grid masked to a soft ellipse. It communicates the consultant's domain (automation, pipelines) without words. The left half is white copy: three-line headline (middle line in teal-600), subtext, the single Ember CTA plus one outline secondary, and a proof line.

- **Panel:** `background: #ffffff`; visible from `md` up, hidden on mobile so the copy leads
- **Backdrop:** `.hero-grid-pattern` teal dots at low opacity, no blur, no colored glow (the old `.hero-radial-glow` is removed)
- **Illustration motion:** slow vertical float (`animate-float-warm`) only; no pulses, no flow animations
- **Reduced-motion fallback:** remove the float; show the illustration static at full opacity
- **Known gap:** the illustration uses saturated pink, orange and blue outside the teal + Ember palette. Replace with a teal/ink vector when the source file is available.
- **Legacy:** the animated node board (pulsing pipeline nodes, dashed SVG connectors) is retired and its styles removed from `HeroWarmTealWash.razor.css`.

---

## 6. Do's and Don'ts

### Do

- **Do** use Action Orange (`#F0642A`) exclusively for the single primary CTA per screen, via `.btn-cta`. Its scarcity is the point.
- **Do** set body text to `#374151` (ink-body) or `#2F4E51` (teal-700) minimum — never lighter — to maintain ≥ 4.5:1 contrast on white.
- **Do** cap display headings at `3.75rem`. Above that is shouting.
- **Do** use `text-wrap: balance` on h1–h3 and `text-wrap: pretty` on prose blocks.
- **Do** stagger animated elements in sequence (0.3s–0.5s increments) so motion reads as flow, not simultaneous burst.
- **Do** wrap all animations in `@media (prefers-reduced-motion: reduce)` with a crossfade or instant-state fallback.
- **Do** use the teal-cyan-aqua scale for all tinted UI surfaces, dark gradients, and dark sidebars — never legacy `cloudzen-steel` (`#2c194d`).
- **Do** keep section backgrounds flat: white, `gray-50`, or a single teal-50 tint. No diagonal `bg-gradient-to-*` washes behind content.
- **Do** use rounded-full silhouettes for all buttons to maintain the approachable-technical balance.
- **Do** ensure interactive cards have a visible hover state (border-color shift + `hover-soft` shadow, no vertical movement) with `transition: border-color, box-shadow 0.3s ease-out`.
- **Do** keep line length at 65–72ch for reading-flow body sections.

### Don't

- **Don't** add top accent bars (`scale-x` reveal), hover lifts (`translateY`) or glows to cards.
- **Don't** add hover scale, shimmer sweeps, ping halos, or colored glows to buttons. The CTA answers with a color step and a 1px press.
- **Don't** use orange for anything other than the primary CTA button. No orange headings, orange borders, orange backgrounds on content sections.
- **Don't** use gradient text (`background-clip: text` + gradient). All heading text is a solid color.
- **Don't** introduce a warm cream/beige body background (`#fcf9f5`, `#fdf8f5`, or any OKLCH L > 0.93, C > 0.01, hue 40–100). The hero is white; no variant keeps cream.
- **Don't** add a third typeface. IBM Plex Sans + Helvetica Neue is the complete system. More than two feels like indecision.
- **Don't** use all-caps for anything longer than 4 words or larger than `0.75rem` body text.
- **Don't** add a colored left-border stripe (`border-left > 1px`) as a card or callout accent. Use background tint or full border instead.
- **Don't** animate layout properties (width, height, top, left). Animate transform and opacity only.
- **Don't** stock-photo or generic-service-bureau the hero — every visual element should demonstrate the consultant's actual domain (cloud, automation, .NET).
- **Don't** use eyebrow labels (small uppercase tracked text above every section heading) as a default scaffold. Use structural variation — leading numbers on genuine sequences, descriptive subheadings, or nothing.
- **Don't** use the legacy `cloudzen-steel` (`#2c194d`) purple on any new component. Replace with `teal-900`/`teal-800` on dark surfaces.
- **Don't** use `z-index: 999` or `z-index: 9999` arbitrary stacking. The established z-scale is: dropdown (10) → sticky header (40) → mobile overlay (45) → modal-backdrop (50) → modal (60) → toast (70) → tooltip (80).
- **Don't** gate content visibility on a class-triggered animation. Elements must be fully visible in their default state; transitions enhance, they don't reveal.
