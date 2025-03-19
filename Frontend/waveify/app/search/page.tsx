import Header from "@/component/Header";
import SearchInput from "@/component/SearchInput";
import { Menu } from "antd";
import Link from 'next/link';

const categories = [
{key: "all", label: <Link href={"search/all"}>All</Link>},
{key: "music", label: <Link href={"search/music"}>Music</Link>},
{key: "beats", label: <Link href={"search/beats"}>Beats</Link>},
{key: "playlist", label: <Link href={"search/playlist"}>Playlist</Link>},
{key: "tags", label: <Link href={"search/tags"}>Tags</Link>},
{key: "drumkits", label: <Link href={"/drumkits"}>Drum Kits</Link>},
];

const Search = () => {
    return (
        <div className="
        p-4
        bg-neutral-900
        rounded-lg
        w-full h-full
        overflow-hidden
        overflow-y-auto">
        
              <div className="mb-2 flex-col gap-y-6">
                <h1 className=" mb-4 text-white text-3xl font-semibold">
                    Search
                </h1>
                <SearchInput/>
                <h1 className="hidden md:block mt-10 mb-4 text-white text-3xl font-semibold text-center">
                Search results for:
                </h1>
                <Menu 
                  theme="dark"
                  mode = "horizontal"
                  items={categories}
                  style={{ flex:1, minWidth: 0, background:"transparent", justifyContent: 'center', border:"white"}}
                /> 
              </div>
           
        </div>
    )
};

export default Search;