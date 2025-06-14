// @ts-check
import { defineConfig } from "astro/config";
import starlight from "@astrojs/starlight";

// https://astro.build/config
export default defineConfig({
  integrations: [
    starlight({
      title: "NBTMap Explorer",
      defaultLocale: "en",
      locales: {
        en: {
          label: "English",
        },
        es: {
          label: "Español",
        },
      },
      social: [
        {
          icon: "github",
          label: "GitHub",
          href: "https://github.com/Jorgemacias-12/Minecraft-Map-To-Image",
        },
      ],
      sidebar: [],
    }),
  ],
});
