import type { Metadata } from "next";
import {Figtree} from "next/font/google"
import "./globals.css";
import Sidebar from "@/component/Sidebar";
import ModalProvider from "@/providers/ModalProvider";
import Header from "@/component/Header";
import Player from "@/component/Player";
const font = Figtree({subsets: ['latin']});

export const metadata: Metadata = {
  title: "Waveify",
  description: "MusicApp",
};

export default function RootLayout({
  children,
}: Readonly<{ children: React.ReactNode }>) {
  return (
    <html lang="en">
      <body className="font-sans bg-gray-900 text-white">
        <ModalProvider />
        
        {/* Контейнер для всего приложения */}
        <div className="flex flex-col h-screen  ">
          
          {/* Header (фиксирован сверху) */}
          <Header /> 
          
          <div className="flex flex-1 overflow-hidden pt-[70px]" >
            {/* Sidebar (фиксирован слева) */}
            {/* <Sidebar /> */}
             
            {/* Основной контент (скроллится) */}
            {/* <main className="flex-1 overflow-y-auto h-[calc(100%-80px)] pr-2 pl-2"></main> */}
            <main className="flex-1 overflow-y-auto  pr-2 pl-2">
              {children}
            </main>
          </div>

          {/* Player (фиксирован снизу) */}
           {/* <Player />  */}
        </div>
      </body>
    </html>
  );
}
