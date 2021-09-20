module.exports = {
  mode: "jit",
  purge: {
    enabled: true,
    content: ["./**/*.razor", "./**/.cshtml"]
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [
      require("@tailwindcss/forms")
  ],
}
