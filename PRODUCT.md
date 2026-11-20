# Product

<!-- impeccable:product-schema 1 -->

## Platform

web

## Users

Owners and operators of small and medium businesses who run on outdated systems and manual workflows and do not have an in-house technical team. They need someone to explain options in business terms, scope a practical fix, and deliver it. They arrive unsure what they need, leave quickly on jargon or generic agency copy, and look for a plain-language sign that the person can deliver. Secondary audiences: technical decision-makers (CTOs, founders) and developer peers or recruiters who want a fast credibility signal.

## Product Purpose

CloudZen is the personal showcase of a cloud software consultant specialising in Azure, .NET, and automation. It exists to convert a qualified visitor's initial curiosity into a concrete next step — a booked discovery call or a direct message — by demonstrating real capability through working examples, clear explanations of process, and a UI that itself reflects technical taste. Success is a visitor who books a call or sends a message because they saw enough evidence to trust, not because they were persuaded.

## Positioning

One engineer who translates technology into business terms and delivers practical automation, including AI, without jargon. A buyer works directly with the person who builds the solution, not with an agency layer.

## Operating Context

Visitors evaluate CloudZen from a browser, often on a phone between other work, before booking a discovery call or sending a message. The site is a Blazor WebAssembly app with Azure Functions behind it. Booking, contact and chat are the conversion paths. Services on offer: system modernization, smart automation, cloud migration, custom software development, AI-powered solutions.

## Brand Personality

Empowering, minimal, practical. The site should feel like a well-built tool, not a sales brochure. Voice is direct and specific; it describes real outcomes in the owner's terms, names a technology only when it helps the decision, and skips adjectives that could apply to anyone. Emotional goal: the visitor finishes the page thinking "this person clearly knows what they're doing and I know exactly what I'd be hiring them for."

## Anti-references

- **Stock-heavy corporate CV clutter**: walls of logos, generic stock photography of handshakes or server racks, credential-dump layouts.
- **Aggressive salesy aesthetics**: countdown timers, "LIMITED OFFER" banners, high-pressure copy, neon-on-dark urgency.
- **Dated Web 2.0 overlays**: glossy bevels, embossed text, gradient-everywhere legacy patterns.
- **Inconsistent typographic hierarchy**: three competing font sizes on the same screen, decorative typefaces used for body copy, or sections that feel visually unrelated.
- **The Black Box vibe**: opaque, mysterious, "we can't tell you what we do" agency energy. Everything here is transparent and specific.
- **Generic service bureau feel**: interchangeable with any other "digital transformation partner" — no voice, no personality, no evidence.
- **Disconnected transitions**: page sections that feel spliced rather than composed; motion that starts over at each section instead of advancing a single narrative thread.

## Design Principles

1. **Show work, not credentials.** Demonstrate capability through real examples and process flows. CVs list; portfolios prove. If a section can't point to something built, it doesn't earn space.
2. **Earn trust without pitching.** Credibility comes from precision and consistency — correct contrast, intentional spacing, working interactions — not from superlatives. Never claim something the page doesn't demonstrate.
3. **Motion as narrative thread.** Every animation advances the visitor's path through the page. Transitions connect sections rather than punctuate them. No entrance effect fires in isolation from what came before or after.
4. **Minimal surface, maximum signal.** Remove anything that doesn't inform or invite action. White space is not emptiness; it is the margin of a confident layout.
5. **Plain-language craft.** The primary audience does not read code, but they feel quality. Build with the care of someone who sweats the details: consistent spacing and type, working interactions, no jank. Explain in business terms and name a technology only when it helps the owner decide.

## Brand Commitments

The parent identity is SmartSystems with CloudZen as the sub-line. The mark is a brain with circuit traces, not a cloud. The lockup is bold black SMARTSYSTEMS over a small teal CLOUDZEN with hairlines. The logo is a PNG raster; no vector source exists yet.

## Evidence on Hand

- Case studies and project entries on the site (`Features/Landing/Components/CaseStudies.razor`, `Features/Projects`) are confirmed as real and publishable.
- Public code and profiles: github.com/dariemcarlosdev and linkedin.com/in/dariemcmacias.
- Not available, so future work must not invent them: client testimonials, client logos, pricing, or benchmark numbers.

## Product Principles

1. **Plain language first.** Describe outcomes in the owner's terms; name technologies only when they help the buyer decide.
2. **Show work, not credentials.** Every claim points to something built or a profile that can be checked.
3. **One clear next step.** Booking a call is the primary action; everything else supports that decision.
4. **Specific over superlative.** Say what was built and what changed. Never claim something the page does not demonstrate.
5. **Built with care, visibly.** The site is itself evidence of technical judgment: consistent, accessible, no jank.

## Accessibility & Inclusion

WCAG 2.1 AA minimum. Body text ≥ 4.5:1 contrast against its background; large text and UI components ≥ 3:1. All animations respect `prefers-reduced-motion` (crossfade or instant fallback). Keyboard navigation through all interactive elements. No information conveyed by colour alone.
