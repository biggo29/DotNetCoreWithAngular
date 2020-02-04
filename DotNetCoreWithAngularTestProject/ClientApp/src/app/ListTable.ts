import { Trade } from "./Trade";
import { Level } from "./Level";

export class ListTable {
    listTableId: number;
    tradeId: number;
    levelId: number;
    syllabusName: string;
    syllabusFilePath: string;
    testPlanFilePath: string;
    language: string;
    developmentOfficer: string;
    manager: string;
    activeDate: string;
    modifiedBy: string;
    modifiedDate: string;
    status: boolean;
    trade: Trade;
    level: Level;
    fileSyllabus: File;
    fileTestPlan: File;
}
