import { Inter } from "next/font/google";
import "./globals.css";

const inter = Inter({ subsets: ["latin"] });

export const metadata = {
  title: "SimpleCRUD",
  description: "test my habilities in nodejs",
};

export default function RootLayout({ children }) {
  return (
    <html className="bg-black" lang="en">
      <body className={inter.className}>{children}</body>
    </html>
  );
}
