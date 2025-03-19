"use client"
import { useRouter } from "next/navigation";
import { BiLibrary, BiSearch } from "react-icons/bi";
import { HiHome } from "react-icons/hi";
import { RxCaretDown, RxCaretLeft, RxCaretRight } from "react-icons/rx";
import { twMerge } from "tailwind-merge";
import ButtonLogin from "./ButtonLogin";
import { SlCloudDownload } from "react-icons/sl";
import { GoHome } from "react-icons/go";
import { usePathname } from "next/navigation";
import { useMemo, useEffect, useState } from "react";
import SidebarItem from "./SidebarItem";
import { CiStar } from "react-icons/ci";

interface HeaderProps {
    children: React.ReactNode;
    className?: string;
}

const Header: React.FC<HeaderProps> = ({
    children,
    className
}) => {
    const pathname = usePathname();
    const router = useRouter();

    const route = useMemo(() => [
        {   
            icon: <GoHome size={26} />, 
            label: "Home", 
            active: pathname === "/", 
            href: "/"
        },
        {
            icon: <BiSearch size={26} />, 
            label: "Search", 
            active: pathname === "/search", 
            href: "/search"
        },
    ], [pathname]);

    return (
        <div className={twMerge(`fixed top-0 left-0 w-full z-50 bg-black p-3 h-16 flex items-center`, className)}>
            <div className="w-full flex items-center justify-between h-full px-4">
                <div className="hidden md:flex gap-x-2 items-left">
                    <button 
                        onClick={() => router.back()} 
                        className="rounded-full bg-black flex items-center justify-left hover:opacity-75 transition">
                        <RxCaretLeft className="text-white" size={35} />
                    </button>
                    <button 
                        onClick={() => router.forward()} 
                        className="rounded-full bg-black flex items-center justify-left hover:opacity-75 transition">
                        <RxCaretRight className="text-white" size={35} />
                    </button>
                </div>
                <div className="md:hidden">
                    <button 
                        onClick={() => router.back()} 
                        className="rounded-full bg-black flex items-center justify-left hover:opacity-75 transition">
                        <RxCaretDown className="text-white" size={35} />
                    </button>
                </div>
                {/* Home Search PC MAIN Button */}
                <div id="nav-center" className="flex gap-x-2 items-center justify-center flex-1"> 
                    {route.map((item) => (
                        <SidebarItem key={item.label} {...item} />
                    ))}
                </div>
                
                {/* Right Section */}
                <div id="right-section" className="flex items-center gap-x-4">
                    <ButtonLogin onClick={() => window.location.href = "/premium"} className="hidden md:flex bg-gradient-to-r from-violet-200 to-pink-200 text-black hover:scale-102 rounded-lg px-4 py-2">
                        <h1 className="text-black font-bold whitespace-nowrap">Learn more Premium</h1>
                    </ButtonLogin>
                    <ButtonLogin onClick={() => window.location.href = "/download"} className="hidden md:block bg-transparent text-neutral-300 font-medium">
                        <SlCloudDownload className="text-white" size={25} />
                    </ButtonLogin>
                    <ButtonLogin onClick={() => {}} className="bg-transparent text-neutral-300 text-sm font-medium md:text-base">
                        Sign Up
                    </ButtonLogin>
                    <ButtonLogin onClick={() => {}} className="bg-white px-6 py-2 text-sm  md:text-base ">
                        Log In
                    </ButtonLogin>
                </div>
            </div>
            {children}
        </div>
    );
};
export default Header;