﻿namespace Email.Tests

open Expecto
open FsRegEx

module Ultimate =

    [<Literal>]
    /// http://www.ex-parrot.com/pdw/Mail-RFC822-Address.html
    let UltimateRegex = """(?:(?:\r\n)?[ \t])*(?:(?:(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*|(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)*\<(?:(?:\r\n)?[ \t])*(?:@(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*(?:,@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*)*:(?:(?:\r\n)?[ \t])*)?(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*\>(?:(?:\r\n)?[ \t])*)|(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)*:(?:(?:\r\n)?[ \t])*(?:(?:(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*|(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)*\<(?:(?:\r\n)?[ \t])*(?:@(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*(?:,@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*)*:(?:(?:\r\n)?[ \t])*)?(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*\>(?:(?:\r\n)?[ \t])*)(?:,\s*(?:(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*|(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)*\<(?:(?:\r\n)?[ \t])*(?:@(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*(?:,@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*)*:(?:(?:\r\n)?[ \t])*)?(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|"(?:[^\"\r\\]|\\.|(?:(?:\r\n)?[ \t]))*"(?:(?:\r\n)?[ \t])*))*@(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*)(?:\.(?:(?:\r\n)?[ \t])*(?:[^()<>@,;:\\".\[\] \000-\031]+(?:(?:(?:\r\n)?[ \t])+|\Z|(?=[\["()<>@,;:\\".\[\]]))|\[([^\[\]\r\\]|\\.)*\](?:(?:\r\n)?[ \t])*))*\>(?:(?:\r\n)?[ \t])*))*)?;\s*)"""
    let ultimateRegex = new FsRegEx(UltimateRegex)

    [<Tests>]
    let testUltimate =
        testList "Ultimate" [
            RFC822.test1 ultimateRegex.IsMatch 
            RFC822.test2 ultimateRegex.IsMatch
            RFC822.test3 ultimateRegex.IsMatch
            RFC822.test4 ultimateRegex.IsMatch
            RFC822.test5 ultimateRegex.IsMatch
            RFC822.test6 ultimateRegex.IsMatch
            RFC822.test7 ultimateRegex.IsMatch
            RFC822.test8 ultimateRegex.IsMatch
            RFC822.test9 ultimateRegex.IsMatch
            RFC822.test10 ultimateRegex.IsMatch
            RFC822.test11 ultimateRegex.IsMatch
            RFC822.test12 ultimateRegex.IsMatch
            RFC822.test13 ultimateRegex.IsMatch
            RFC822.test14 ultimateRegex.IsMatch
            RFC822.test15 ultimateRegex.IsMatch
            RFC822.test16 ultimateRegex.IsMatch
            RFC822.test17 ultimateRegex.IsMatch
            RFC822.test18 ultimateRegex.IsMatch
            RFC822.test19 ultimateRegex.IsMatch
            RFC822.test20 ultimateRegex.IsMatch
            RFC822.test21 ultimateRegex.IsMatch
            RFC822.test22 ultimateRegex.IsMatch
            RFC822.test23 ultimateRegex.IsMatch
            RFC822.test24 ultimateRegex.IsMatch
            RFC822.test25 ultimateRegex.IsMatch
            RFC822.test26 ultimateRegex.IsMatch
            RFC822.test27 ultimateRegex.IsMatch
            RFC822.test28 ultimateRegex.IsMatch
            RFC822.test29 ultimateRegex.IsMatch
            RFC822.test30 ultimateRegex.IsMatch
            RFC822.test31 ultimateRegex.IsMatch
            RFC822.test32 ultimateRegex.IsMatch
            RFC822.test33 ultimateRegex.IsMatch
            RFC822.test34 ultimateRegex.IsMatch
            RFC822.test35 ultimateRegex.IsMatch
            RFC822.test36 ultimateRegex.IsMatch
            RFC822.test37 ultimateRegex.IsMatch
            RFC822.test38 ultimateRegex.IsMatch
            RFC822.test39 ultimateRegex.IsMatch
            RFC822.test40 ultimateRegex.IsMatch
            RFC822.test41 ultimateRegex.IsMatch
            RFC822.test42 ultimateRegex.IsMatch
            RFC822.test43 ultimateRegex.IsMatch
            RFC822.test44 ultimateRegex.IsMatch
            RFC822.test45 ultimateRegex.IsMatch
            RFC822.test46 ultimateRegex.IsMatch
            RFC822.test47 ultimateRegex.IsMatch
            RFC822.test48 ultimateRegex.IsMatch
            RFC822.test49 ultimateRegex.IsMatch
            RFC822.test50 ultimateRegex.IsMatch
            RFC822.test51 ultimateRegex.IsMatch
            RFC822.test52 ultimateRegex.IsMatch
            RFC822.test53 ultimateRegex.IsMatch
            RFC822.test54 ultimateRegex.IsMatch
            RFC822.test55 ultimateRegex.IsMatch
            RFC822.test56 ultimateRegex.IsMatch
            RFC822.test57 ultimateRegex.IsMatch
            RFC822.test58 ultimateRegex.IsMatch
            RFC822.test59 ultimateRegex.IsMatch
            RFC822.test60 ultimateRegex.IsMatch
            RFC822.test61 ultimateRegex.IsMatch
            RFC822.test62 ultimateRegex.IsMatch
            RFC822.test63 ultimateRegex.IsMatch
            RFC822.test64 ultimateRegex.IsMatch
            RFC822.test65 ultimateRegex.IsMatch
            RFC822.test66 ultimateRegex.IsMatch
            RFC822.test67 ultimateRegex.IsMatch
            RFC822.test68 ultimateRegex.IsMatch
            RFC822.test69 ultimateRegex.IsMatch
            RFC822.test70 ultimateRegex.IsMatch
            RFC822.test71 ultimateRegex.IsMatch
            RFC822.test72 ultimateRegex.IsMatch
            RFC822.test73 ultimateRegex.IsMatch
            RFC822.test74 ultimateRegex.IsMatch
            RFC822.test75 ultimateRegex.IsMatch
            RFC822.test76 ultimateRegex.IsMatch
            RFC822.test77 ultimateRegex.IsMatch
            RFC822.test78 ultimateRegex.IsMatch
            RFC822.test79 ultimateRegex.IsMatch
            RFC822.test80 ultimateRegex.IsMatch
            RFC822.test81 ultimateRegex.IsMatch
            RFC822.test82 ultimateRegex.IsMatch
            RFC822.test83 ultimateRegex.IsMatch
            RFC822.test84 ultimateRegex.IsMatch
            RFC822.test85 ultimateRegex.IsMatch
            RFC822.test86 ultimateRegex.IsMatch
            RFC822.test87 ultimateRegex.IsMatch
            RFC822.test88 ultimateRegex.IsMatch
            RFC822.test89 ultimateRegex.IsMatch
            RFC822.test90 ultimateRegex.IsMatch
            RFC822.test91 ultimateRegex.IsMatch
            RFC822.test92 ultimateRegex.IsMatch
            RFC822.test93 ultimateRegex.IsMatch
            RFC822.test94 ultimateRegex.IsMatch
            RFC822.test95 ultimateRegex.IsMatch
            RFC822.test96 ultimateRegex.IsMatch
            RFC822.test97 ultimateRegex.IsMatch
            RFC822.test98 ultimateRegex.IsMatch
            RFC822.test99 ultimateRegex.IsMatch
            RFC822.test100 ultimateRegex.IsMatch
            RFC822.test101 ultimateRegex.IsMatch
            RFC822.test102 ultimateRegex.IsMatch
            RFC822.test103 ultimateRegex.IsMatch
            RFC822.test104 ultimateRegex.IsMatch
            RFC822.test105 ultimateRegex.IsMatch
            RFC822.test106 ultimateRegex.IsMatch
            RFC822.test107 ultimateRegex.IsMatch
            RFC822.test108 ultimateRegex.IsMatch
            RFC822.test109 ultimateRegex.IsMatch
            RFC822.test110 ultimateRegex.IsMatch
            RFC822.test111 ultimateRegex.IsMatch
            RFC822.test112 ultimateRegex.IsMatch
            RFC822.test113 ultimateRegex.IsMatch
            RFC822.test114 ultimateRegex.IsMatch
            RFC822.test115 ultimateRegex.IsMatch
            RFC822.test116 ultimateRegex.IsMatch
            RFC822.test117 ultimateRegex.IsMatch
            RFC822.test118 ultimateRegex.IsMatch
            RFC822.test119 ultimateRegex.IsMatch
            RFC822.test120 ultimateRegex.IsMatch
            RFC822.test121 ultimateRegex.IsMatch
            RFC822.test122 ultimateRegex.IsMatch
            RFC822.test123 ultimateRegex.IsMatch
            RFC822.test124 ultimateRegex.IsMatch
            RFC822.test125 ultimateRegex.IsMatch
            RFC822.test126 ultimateRegex.IsMatch
            RFC822.test127 ultimateRegex.IsMatch
            RFC822.test128 ultimateRegex.IsMatch
            RFC822.test129 ultimateRegex.IsMatch
            RFC822.test130 ultimateRegex.IsMatch
            RFC822.test131 ultimateRegex.IsMatch
            RFC822.test132 ultimateRegex.IsMatch
            RFC822.test133 ultimateRegex.IsMatch
            RFC822.test134 ultimateRegex.IsMatch
            RFC822.test135 ultimateRegex.IsMatch
            RFC822.test136 ultimateRegex.IsMatch
            RFC822.test137 ultimateRegex.IsMatch
            RFC822.test138 ultimateRegex.IsMatch
            RFC822.test139 ultimateRegex.IsMatch
            RFC822.test140 ultimateRegex.IsMatch
            RFC822.test141 ultimateRegex.IsMatch
            RFC822.test142 ultimateRegex.IsMatch
            RFC822.test143 ultimateRegex.IsMatch
            RFC822.test144 ultimateRegex.IsMatch
            RFC822.test145 ultimateRegex.IsMatch
            RFC822.test146 ultimateRegex.IsMatch
            RFC822.test147 ultimateRegex.IsMatch
            RFC822.test148 ultimateRegex.IsMatch
            RFC822.test149 ultimateRegex.IsMatch
            RFC822.test150 ultimateRegex.IsMatch
            RFC822.test151 ultimateRegex.IsMatch
            RFC822.test152 ultimateRegex.IsMatch
            RFC822.test153 ultimateRegex.IsMatch
            RFC822.test154 ultimateRegex.IsMatch
            RFC822.test155 ultimateRegex.IsMatch
            RFC822.test156 ultimateRegex.IsMatch
            RFC822.test157 ultimateRegex.IsMatch
            RFC822.test158 ultimateRegex.IsMatch
            RFC822.test159 ultimateRegex.IsMatch
            RFC822.test160 ultimateRegex.IsMatch
            RFC822.test161 ultimateRegex.IsMatch
            RFC822.test162 ultimateRegex.IsMatch
            RFC822.test163 ultimateRegex.IsMatch
            RFC822.test164 ultimateRegex.IsMatch
            RFC822.test165 ultimateRegex.IsMatch
            RFC822.test166 ultimateRegex.IsMatch
            RFC822.test167 ultimateRegex.IsMatch
            RFC822.test168 ultimateRegex.IsMatch
            RFC822.test169 ultimateRegex.IsMatch
            RFC822.test170 ultimateRegex.IsMatch
            RFC822.test171 ultimateRegex.IsMatch
            RFC822.test172 ultimateRegex.IsMatch
            RFC822.test173 ultimateRegex.IsMatch
            RFC822.test174 ultimateRegex.IsMatch
            RFC822.test175 ultimateRegex.IsMatch
            RFC822.test176 ultimateRegex.IsMatch
            RFC822.test177 ultimateRegex.IsMatch
            RFC822.test178 ultimateRegex.IsMatch
            RFC822.test179 ultimateRegex.IsMatch
            RFC822.test180 ultimateRegex.IsMatch
            RFC822.test181 ultimateRegex.IsMatch
            RFC822.test182 ultimateRegex.IsMatch
            RFC822.test183 ultimateRegex.IsMatch
            RFC822.test184 ultimateRegex.IsMatch
            RFC822.test185 ultimateRegex.IsMatch
            RFC822.test186 ultimateRegex.IsMatch
            RFC822.test187 ultimateRegex.IsMatch
            RFC822.test188 ultimateRegex.IsMatch
            RFC822.test189 ultimateRegex.IsMatch
            RFC822.test190 ultimateRegex.IsMatch
            RFC822.test191 ultimateRegex.IsMatch
            RFC822.test192 ultimateRegex.IsMatch
            RFC822.test193 ultimateRegex.IsMatch
            RFC822.test194 ultimateRegex.IsMatch
            RFC822.test195 ultimateRegex.IsMatch
            RFC822.test196 ultimateRegex.IsMatch
            RFC822.test197 ultimateRegex.IsMatch
            RFC822.test198 ultimateRegex.IsMatch
            RFC822.test199 ultimateRegex.IsMatch
            RFC822.test200 ultimateRegex.IsMatch
            RFC822.test201 ultimateRegex.IsMatch
            RFC822.test202 ultimateRegex.IsMatch
            RFC822.test203 ultimateRegex.IsMatch
            RFC822.test204 ultimateRegex.IsMatch
            RFC822.test205 ultimateRegex.IsMatch
            RFC822.test206 ultimateRegex.IsMatch
            RFC822.test207 ultimateRegex.IsMatch
            RFC822.test208 ultimateRegex.IsMatch
            RFC822.test209 ultimateRegex.IsMatch
            RFC822.test210 ultimateRegex.IsMatch
            RFC822.test211 ultimateRegex.IsMatch
            RFC822.test212 ultimateRegex.IsMatch
            RFC822.test213 ultimateRegex.IsMatch
            RFC822.test214 ultimateRegex.IsMatch
            RFC822.test215 ultimateRegex.IsMatch
            RFC822.test216 ultimateRegex.IsMatch
            RFC822.test217 ultimateRegex.IsMatch
            RFC822.test218 ultimateRegex.IsMatch
            RFC822.test219 ultimateRegex.IsMatch
            RFC822.test220 ultimateRegex.IsMatch
            RFC822.test221 ultimateRegex.IsMatch
            RFC822.test222 ultimateRegex.IsMatch
            RFC822.test223 ultimateRegex.IsMatch
            RFC822.test224 ultimateRegex.IsMatch
            RFC822.test225 ultimateRegex.IsMatch
            RFC822.test226 ultimateRegex.IsMatch
            RFC822.test227 ultimateRegex.IsMatch
            RFC822.test228 ultimateRegex.IsMatch
            RFC822.test229 ultimateRegex.IsMatch
            RFC822.test230 ultimateRegex.IsMatch
            RFC822.test231 ultimateRegex.IsMatch
            RFC822.test232 ultimateRegex.IsMatch
            RFC822.test233 ultimateRegex.IsMatch
            RFC822.test234 ultimateRegex.IsMatch
            RFC822.test235 ultimateRegex.IsMatch
            RFC822.test236 ultimateRegex.IsMatch
            RFC822.test237 ultimateRegex.IsMatch
            RFC822.test238 ultimateRegex.IsMatch
            RFC822.test239 ultimateRegex.IsMatch
            RFC822.test240 ultimateRegex.IsMatch
            RFC822.test241 ultimateRegex.IsMatch
            RFC822.test242 ultimateRegex.IsMatch
            RFC822.test243 ultimateRegex.IsMatch
            RFC822.test244 ultimateRegex.IsMatch
            RFC822.test245 ultimateRegex.IsMatch
            RFC822.test246 ultimateRegex.IsMatch
            RFC822.test247 ultimateRegex.IsMatch
            RFC822.test248 ultimateRegex.IsMatch
            RFC822.test249 ultimateRegex.IsMatch
            RFC822.test250 ultimateRegex.IsMatch
            RFC822.test251 ultimateRegex.IsMatch
            RFC822.test252 ultimateRegex.IsMatch
            RFC822.test253 ultimateRegex.IsMatch
            RFC822.test254 ultimateRegex.IsMatch
            RFC822.test255 ultimateRegex.IsMatch
            RFC822.test256 ultimateRegex.IsMatch
            RFC822.test257 ultimateRegex.IsMatch
            RFC822.test258 ultimateRegex.IsMatch
            RFC822.test259 ultimateRegex.IsMatch
            RFC822.test260 ultimateRegex.IsMatch
            RFC822.test261 ultimateRegex.IsMatch
            RFC822.test262 ultimateRegex.IsMatch
            RFC822.test263 ultimateRegex.IsMatch
            RFC822.test264 ultimateRegex.IsMatch
            RFC822.test265 ultimateRegex.IsMatch
            RFC822.test266 ultimateRegex.IsMatch
            RFC822.test267 ultimateRegex.IsMatch
            RFC822.test268 ultimateRegex.IsMatch
            RFC822.test269 ultimateRegex.IsMatch
            RFC822.test270 ultimateRegex.IsMatch
            RFC822.test271 ultimateRegex.IsMatch
            RFC822.test272 ultimateRegex.IsMatch
            RFC822.test273 ultimateRegex.IsMatch
            RFC822.test274 ultimateRegex.IsMatch
            RFC822.test275 ultimateRegex.IsMatch
            RFC822.test276 ultimateRegex.IsMatch
            RFC822.test277 ultimateRegex.IsMatch
            RFC822.test278 ultimateRegex.IsMatch
            RFC822.test279 ultimateRegex.IsMatch
            RFC822.test280 ultimateRegex.IsMatch
            ]

