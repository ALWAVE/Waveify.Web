import Header from "@/component/Header";
import ListItem from "@/component/ListItem";
import PageContent from "./PageContent";

export default function Home() {
  return (
    <div className="
    bg-neutral-900 text-neutral-400 rounded-lg w-full h-full overflow-hidden overflow-y-auto
        
    ">
    
        <div className="mb-4"> {/* Уменьшите отступ, если нужно */}
          <h1 className="text-white text-3xl font-semibold">
            Welcome back
          </h1>
          <div className="
            grid
            grid-cols-1
            sm:grid-cols-2
            xl:grid-cols-3
            2xl:grid-cols-4
            gap-3
            mt-4
          ">
            <ListItem>
              {/* Содержимое ListItem */}
            </ListItem>
          </div>
        </div>
      
      <div className="mt-2 mb-7 px-6">
        <div className="flex justify-between items-center">
          <h1 className="text-white text-2xl font-semibold">
              New songs
          </h1>
        </div>
        <PageContent/>
      </div>
    </div>
  );
}
