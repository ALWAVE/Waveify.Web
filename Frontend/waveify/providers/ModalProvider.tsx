"use client"
import AuthModal from "@/component/AuthModal";
import {useEffect, useState } from "react"

 
const ModalProvider = () => {
    const [isMounted, setIsMounted] = useState(false);
    useEffect(() => {
        setIsMounted(true);
    }, []);
    if(!isMounted)
        return null;
    
    return (
        <>
        
        </>
    )
};
export default ModalProvider;