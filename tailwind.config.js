/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './Pages/**/*.cshtml',
        './Views/**/*.cshtml'
    ],
    theme: {
        container : {
        
            padding: '3rem',
        },
    extend: {},
    },
    daisyui: {
        themes: [
            "luxury",
            "forest",
            "business",
            "night",
            {
                mytheme: {

                    "primary": "#1e3a8a",

                    "secondary": "#7c3aed",

                    "accent": "#0d9668",

                    "neutral": "#6b7280",

                    "base-100": "#111827",

                    "info": "#43a7f4",

                    "success": "#117363",

                    "warning": "#fcae27",

                    "error": "#9d174d",
                },
            },
        ],
    },
    plugins: [require("daisyui")],
}

